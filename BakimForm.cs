using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BelediyeAtikUygulamasi
{
    public partial class BakimForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BelediyeAtikDB_D;Integrated Security=True");

        public BakimForm()
        {
            InitializeComponent();
        }

        private void BakimForm_Load(object sender, EventArgs e)
        {
            AraclariGetir();
            BakimListele();

            // Bakım Tipleri
            cmbBakimTipi.Items.Clear();
            cmbBakimTipi.Items.Add("Standart");
            cmbBakimTipi.Items.Add("Ağır");

            cmbBakimTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAraclar.DropDownStyle = ComboBoxStyle.DropDownList;

            // Tablo Görünümü
            dgvBakimlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBakimlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBakimlar.RowHeadersVisible = false;
            dgvBakimlar.BackgroundColor = Color.White;
        }

        void AraclariGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT Plaka FROM Araclar", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmbAraclar.Items.Add(dr[0].ToString());
                }
                baglanti.Close();
            }
            catch { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        void BakimListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BakimKayitlari ORDER BY Tarih DESC", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBakimlar.DataSource = dt;
                baglanti.Close();
            }
            catch { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        // Fiyat Gösterme Kısmı
        private void cmbBakimTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBakimTipi.Text == "Standart")
            {
                lblMaliyet.Text = "BAKIM MALİYETİ: 5.000 TL";
                lblMaliyet.ForeColor = Color.DarkBlue;
            }
            else if (cmbBakimTipi.Text == "Ağır")
            {
                lblMaliyet.Text = "BAKIM MALİYETİ: 12.000 TL";
                lblMaliyet.ForeColor = Color.Red;
            }
        }

        // --- TEKNİSYEN KONTROLÜ ---
        // Girilen TC veritabanında var mı ve görevi Teknisyen mi?
        // --- DÜZELTİLMİŞ TEKNİSYEN KONTROLÜ ---
        bool TeknisyenMi(string tc)
        {
            bool yetkiVar = false;
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // DEĞİŞİKLİK BURADA: 
                // 1. 'Gorev' yerine 'GorevUnvani' yazdık.
                // 2. '=' yerine 'LIKE' yazdık ki "Bakim Teknisyeni"ni de kabul etsin.
                SqlCommand komut = new SqlCommand("SELECT Count(*) FROM Personeller WHERE TC = @tc AND GorevUnvani LIKE '%Teknisyen%'", baglanti);

                komut.Parameters.AddWithValue("@tc", tc);

                int sonuc = Convert.ToInt32(komut.ExecuteScalar());
                if (sonuc > 0) yetkiVar = true;

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                return false;
            }
            return yetkiVar;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. BOŞ ALAN KONTROLÜ (TC dahil)
            if (cmbAraclar.Text == "" || cmbBakimTipi.Text == "" || txtTeknisyenTC.Text == "")
            {
                MessageBox.Show("Lütfen Araç, Bakım Türü ve Teknisyen TC giriniz!");
                return;
            }

            // 2. YETKİ KONTROLÜ
            if (TeknisyenMi(txtTeknisyenTC.Text) == false)
            {
                MessageBox.Show("Bu işlem için yetkiniz yok!\nYa TC hatalı ya da 'Teknisyen' değilsiniz.", "Yetkisiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. KAYIT İŞLEMİ
            Bakim yeniBakim = new Bakim(cmbAraclar.Text, cmbBakimTipi.Text);

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // Açıklama sütunu koddan çıkarıldı
                string sql = @"INSERT INTO BakimKayitlari (AracNO, BakimTuru, Maliyet, Tarih, TeknisyenTC) 
                               VALUES ((SELECT AracNO FROM Araclar WHERE Plaka=@plaka), @tur, @maliyet, GETDATE(), @tc)";

                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@plaka", yeniBakim.AracPlaka);
                komut.Parameters.AddWithValue("@tur", yeniBakim.BakimTipi);
                komut.Parameters.AddWithValue("@maliyet", yeniBakim.Maliyet);
                komut.Parameters.AddWithValue("@tc", txtTeknisyenTC.Text); // TC'yi buradan alıyoruz

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show($"Bakım Başarıyla Kaydedildi.\nTutar: {yeniBakim.Maliyet} TL");
                BakimListele();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvBakimlar.CurrentRow == null || dgvBakimlar.SelectedRows.Count == 0) return;

            DialogResult cevap = MessageBox.Show("Silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgvBakimlar.CurrentRow.Cells["BakimID"].Value); // ID sütun ismine dikkat
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM BakimKayitlari WHERE BakimID=@id", baglanti);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    BakimListele();
                }
                catch { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
            }
        }
    }
}