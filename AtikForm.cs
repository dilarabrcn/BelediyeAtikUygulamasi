using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BelediyeAtikUygulamasi
{
    public partial class AtikForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BelediyeAtikDB_D;Integrated Security=True");
        const int GUNLUK_SINIR = 50000;

        public AtikForm()
        {
            InitializeComponent();
        }

        private void AtikForm_Load(object sender, EventArgs e)
        {
            AraclariGetir();

            cmbAtikTuru.Items.Clear();
            cmbAtikTuru.Items.Add("Organik");
            cmbAtikTuru.Items.Add("Plastik");
            cmbAtikTuru.Items.Add("Metal");
            cmbAtikTuru.Items.Add("Kağıt");
            cmbAtikTuru.Items.Add("Cam");

            cmbAtikTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAraclar.DropDownStyle = ComboBoxStyle.DropDownList;

            KayitlariListele();
            KapasiteGoster();
        }

        void AraclariGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT Plaka FROM Araclar WHERE Durum='AKTİF'", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmbAraclar.Items.Add(dr[0].ToString());
                }
                baglanti.Close();
            }
            catch { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        // --- KAPASİTE GÖSTERGESİ (DÜZELTİLDİ) ---
        int BugunkuToplam()
        {
            int toplam = 0;
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                // Tarih kontrolü saatten bağımsız yapıldı (CAST)
                SqlCommand komut = new SqlCommand("SELECT SUM(GelenMiktarKG) FROM AtikHareketleri WHERE CAST(IslemTarihi AS DATE) = CAST(GETDATE() AS DATE)", baglanti);
                var sonuc = komut.ExecuteScalar();
                if (sonuc != DBNull.Value) toplam = Convert.ToInt32(sonuc);
                baglanti.Close();
            }
            catch { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
            return toplam;
        }

        void KapasiteGoster()
        {
            int dolu = BugunkuToplam();
            int bos = GUNLUK_SINIR - dolu;
            lblKapasite.Text = $"DOLULUK: {dolu} / {GUNLUK_SINIR} KG  (Kalan: {bos} KG)";

            if (dolu >= GUNLUK_SINIR * 0.9) lblKapasite.ForeColor = Color.Red;
            else lblKapasite.ForeColor = Color.Green;
        }

        // --- LİSTELEME (DÜZELTİLDİ) ---
        void KayitlariListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                // Tarih formatı düzeltildi, artık bugünün kayıtları görünür!
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM AtikHareketleri WHERE CAST(IslemTarihi AS DATE) = CAST(GETDATE() AS DATE)", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAtiklar.DataSource = dt;

                // GÖRÜNÜM AYARLARI
                dgvAtiklar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAtiklar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvAtiklar.RowHeadersVisible = false;
                dgvAtiklar.BackgroundColor = Color.White;
                dgvAtiklar.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;

                baglanti.Close();
            }
            catch { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbAraclar.Text == "" || cmbAtikTuru.Text == "" || txtMiktar.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            decimal miktar;
            if (!decimal.TryParse(txtMiktar.Text, out miktar) || miktar <= 0)
            {
                MessageBox.Show("Geçerli bir miktar girin.");
                return;
            }

            int mevcut = BugunkuToplam();
            if (mevcut + miktar > GUNLUK_SINIR)
            {
                MessageBox.Show("Kapasite Doldu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            // 1. PLAKADAN ID BULMA (Foreign Key Hatası Çözümü)
            string gercekAracNo = "";
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand idBul = new SqlCommand("SELECT AracNO FROM Araclar WHERE Plaka = @plaka", baglanti);
                idBul.Parameters.AddWithValue("@plaka", cmbAraclar.Text);
                var sonuc = idBul.ExecuteScalar();
                if (sonuc != null) gercekAracNo = sonuc.ToString();
                else { baglanti.Close(); MessageBox.Show("Araç ID bulunamadı!"); return; }
                baglanti.Close();
            }
            catch { if (baglanti.State == ConnectionState.Open) baglanti.Close(); return; }

            // 2. SINIF İLE HESAPLAMA (Verim, Dönüştürülen Miktar vb.)
            Atik yeniAtik = new Atik(cmbAraclar.Text, cmbAtikTuru.Text, miktar);

            // 3. KAYIT (Tüm Sütunlar Dolu)
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sql = @"INSERT INTO AtikHareketleri 
                               (AracNO, AtikTuru, GelenMiktarKG, DonusturulenMiktarKG, VerimYuzdesi, EldeEdilenGelir, IslemTarihi) 
                               VALUES (@p1, @p2, @p3, @p4, @p5, @p6, GETDATE())";

                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", gercekAracNo);
                komut.Parameters.AddWithValue("@p2", yeniAtik.AtikTuru);
                komut.Parameters.AddWithValue("@p3", yeniAtik.MiktarKG);
                komut.Parameters.AddWithValue("@p4", yeniAtik.DonusturulenMiktar); // Yeni
                komut.Parameters.AddWithValue("@p5", yeniAtik.VerimYuzdesi);       // Yeni
                komut.Parameters.AddWithValue("@p6", yeniAtik.ToplamKazanc);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show($"Kayıt Başarılı!\nVerim: %{yeniAtik.VerimYuzdesi}\nKazanç: {yeniAtik.ToplamKazanc} TL");

                txtMiktar.Clear();
                KayitlariListele(); // Listeyi yenile
                KapasiteGoster();   // Kapasiteyi yenile
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void cmbAtikTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = cmbAtikTuru.Text;
            string oran = "";

            // Oranları belirle
            switch (secilen)
            {
                case "Metal": oran = "%95"; break;
                case "Plastik": oran = "%90"; break;
                case "Cam": oran = "%98"; break;
                case "Kağıt": oran = "%85"; break;
                case "Organik": oran = "%60"; break;
                default: oran = "---"; break;
            }

            // Sadece yazıyı güncelle, renk değişimi yok
            lblVerimOrani.Text = $"Verim Oranı: {oran}";
        }

        // --- SİLME BUTONU ---
        private void btnSil_Click(object sender, EventArgs e)
        {
            // 1. Önce bir satır seçilmiş mi diye kontrol edelim
            if (dgvAtiklar.CurrentRow == null || dgvAtiklar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek satırı seçiniz!");
                return;
            }

            // 2. Güvenlik Sorusu (Yanlışlıkla basarsa diye)
            DialogResult cevap = MessageBox.Show("Bu kaydı kalıcı olarak silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    // 3. Seçili satırın ID'sini alıyoruz (Veritabanı kimliği)
                    // Not: Tablonda 'IslemID' sütunu mutlaka olmalı (Gizli olsa bile çalışır)
                    int silinecekID = Convert.ToInt32(dgvAtiklar.CurrentRow.Cells["IslemID"].Value);

                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                    // 4. Veritabanından silme komutu
                    SqlCommand komut = new SqlCommand("DELETE FROM AtikHareketleri WHERE IslemID = @id", baglanti);
                    komut.Parameters.AddWithValue("@id", silinecekID);
                    komut.ExecuteNonQuery();

                    baglanti.Close();

                    // 5. Listeyi Yenile (Silinen satır ekrandan gitsin)
                    KayitlariListele();

                    // 6. Kapasiteyi Güncelle (Silinen miktar düşsün)
                    KapasiteGoster();

                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    if (baglanti.State == ConnectionState.Open) baglanti.Close();
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }
    } // Metot Bitiş

    } // Class Bitiş (Bunu kontrol et)
 // Namespace Bitiş (En altta bu olmalı)