using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BelediyeAtikUygulamasi
{
    public partial class AracForm : Form
    {
        // 1. BAĞLANTI ADRESİ (Doğru olan)
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BelediyeAtikDB_D;Integrated Security=True");

        public AracForm()
        {
            InitializeComponent();
           

            // --- 1. ARAÇ TİPLERİ ---
            cmbAracTipi.Items.Clear();
            cmbAracTipi.Items.Add("Çöp Kamyonu");
            cmbAracTipi.Items.Add("Geri Dönüşüm Aracı"); // İ harfiyle
            cmbAracTipi.Items.Add("Geri Dönüşüm Araci"); // I harfiyle (Yedek)
            cmbAracTipi.Items.Add("BÖLMELİ KAMYON (Plastik, Metal, Kağıt)");

            // --- 2. Rotalar ---
            cmbRota.Items.Clear();
            cmbRota.Items.Add("MERKEZ");
            cmbRota.Items.Add("KUZEY");
            cmbRota.Items.Add("GÜNEY");
            cmbRota.Items.Add("DOĞU");
            cmbRota.Items.Add("BATI");

            // --- 3. Durumlar (ÇÖPLÜĞÜ TEMİZLEDİK) ---
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("AKTIF");
            cmbDurum.Items.Add("PASIF");
            cmbDurum.Items.Add("BAKIMDA");
            // O fazladan eklediğimiz boşluklu satırları BURADAN SİLDİM.

            // Verileri Yükle
            SoforleriGetir();
            AracListele();

            // Ayarlar
            cmbAracTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRota.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDurum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSorumluSofor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AracForm_Load(object sender, EventArgs e)
        {
        }

        // --- ŞOFÖRLERİ GETİRME (SADECE ŞOFÖRLER) ---
        void SoforleriGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // BURAYA "WHERE" ŞARTI EKLEDİK
                string sorgu = "SELECT TC, AD + ' ' + SOYAD AS AdSoyad FROM Personeller WHERE GorevUnvani = 'Şoför'";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbSorumluSofor.DisplayMember = "AdSoyad";
                cmbSorumluSofor.ValueMember = "TC";
                cmbSorumluSofor.DataSource = dt;

                baglanti.Close();
            }
            catch (Exception ex) { MessageBox.Show("Şoför hatası: " + ex.Message); }
        }

        // --- ARAÇLARI LİSTELEME ---
        void AracListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                string sorgu = @"SELECT A.AracNO, A.Plaka, A.Marka, A.Model, A.KapasiteKG, A.AracTipi, A.RotaBilgisi, A.Durum, 
                                 P.AD + ' ' + P.SOYAD as [Sorumlu Şoför] 
                                 FROM Araclar A 
                                 LEFT JOIN Personeller P ON A.SorumluPersonelTC = P.TC";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAraclar.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex) { MessageBox.Show("Listeleme Hatası: " + ex.Message); }
        }

        // --- BUTON İŞLEMLERİ ---
        private void btnListele_Click(object sender, EventArgs e)
        {
            AracListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAracID.Text == "" || txtPlaka.Text == "")
            {
                MessageBox.Show("Araç ID ve Plaka zorunludur!");
                return;
            }

            // 10 Araç Sınırı
            if (cmbDurum.Text == "AKTİF")
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    SqlCommand komutSay = new SqlCommand("SELECT COUNT(*) FROM Araclar WHERE Durum='AKTİF'", baglanti);
                    int aktifSayisi = (int)komutSay.ExecuteScalar();
                    baglanti.Close();

                    if (aktifSayisi >= 10)
                    {
                        MessageBox.Show("En fazla 10 adet AKTİF araç olabilir!");
                        return;
                    }
                }
                catch { baglanti.Close(); }
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                string sql = @"INSERT INTO Araclar (AracNO, Marka, Model, KapasiteKG, Plaka, AracTipi, RotaBilgisi, Durum, SorumluPersonelTC)
                               VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";

                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", txtAracID.Text.Trim());
                komut.Parameters.AddWithValue("@p2", txtMarka.Text.Trim());
                komut.Parameters.AddWithValue("@p3", txtModel.Text.Trim());
                int kap = 0; int.TryParse(txtKapasite.Text, out kap);
                komut.Parameters.AddWithValue("@p4", kap);
                komut.Parameters.AddWithValue("@p5", txtPlaka.Text.Trim());
                komut.Parameters.AddWithValue("@p6", cmbAracTipi.Text);
                komut.Parameters.AddWithValue("@p7", cmbRota.Text);
                komut.Parameters.AddWithValue("@p8", cmbDurum.Text);

                if (cmbSorumluSofor.SelectedValue != null)
                    komut.Parameters.AddWithValue("@p9", cmbSorumluSofor.SelectedValue.ToString());
                else
                    komut.Parameters.AddWithValue("@p9", DBNull.Value);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Araç Eklendi.");
                AracListele();
            }
            catch (Exception ex) { baglanti.Close(); MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAracID.Text == "")
            {
                MessageBox.Show("Lütfen silinecek aracı seçin.");
                return;
            }

            if (MessageBox.Show("Bu aracı silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM Araclar WHERE AracNO=@p1", baglanti);
                    komut.Parameters.AddWithValue("@p1", txtAracID.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Araç Silindi.");
                    AracListele();
                    txtAracID.Text = ""; txtPlaka.Text = "";
                }
                catch (Exception ex) { baglanti.Close(); MessageBox.Show("Hata: " + ex.Message); }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAracID.Text == "")
            {
                MessageBox.Show("Lütfen güncellenecek aracı seçin.");
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                string sql = @"UPDATE Araclar SET Marka=@p2, Model=@p3, KapasiteKG=@p4, Plaka=@p5, 
                               AracTipi=@p6, RotaBilgisi=@p7, Durum=@p8, SorumluPersonelTC=@p9 
                               WHERE AracNO=@p1";

                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@p1", txtAracID.Text.Trim());
                komut.Parameters.AddWithValue("@p2", txtMarka.Text.Trim());
                komut.Parameters.AddWithValue("@p3", txtModel.Text.Trim());
                int kap = 0; int.TryParse(txtKapasite.Text, out kap);
                komut.Parameters.AddWithValue("@p4", kap);
                komut.Parameters.AddWithValue("@p5", txtPlaka.Text.Trim());
                komut.Parameters.AddWithValue("@p6", cmbAracTipi.Text);
                komut.Parameters.AddWithValue("@p7", cmbRota.Text);
                komut.Parameters.AddWithValue("@p8", cmbDurum.Text);

                if (cmbSorumluSofor.SelectedValue != null)
                    komut.Parameters.AddWithValue("@p9", cmbSorumluSofor.SelectedValue.ToString());
                else
                    komut.Parameters.AddWithValue("@p9", DBNull.Value);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Araç Güncellendi.");
                AracListele();
            }
            catch (Exception ex) { baglanti.Close(); MessageBox.Show("Hata: " + ex.Message); }
        }

        private void dgvAraclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAracID.Text = dgvAraclar.Rows[e.RowIndex].Cells["AracNO"].Value.ToString();
                txtPlaka.Text = dgvAraclar.Rows[e.RowIndex].Cells["Plaka"].Value.ToString();
                txtMarka.Text = dgvAraclar.Rows[e.RowIndex].Cells["Marka"].Value.ToString();
                txtModel.Text = dgvAraclar.Rows[e.RowIndex].Cells["Model"].Value.ToString();
                txtKapasite.Text = dgvAraclar.Rows[e.RowIndex].Cells["KapasiteKG"].Value.ToString();

                cmbAracTipi.Text = dgvAraclar.Rows[e.RowIndex].Cells["AracTipi"].Value.ToString().Trim();
                cmbRota.Text = dgvAraclar.Rows[e.RowIndex].Cells["RotaBilgisi"].Value.ToString().Trim();
                cmbDurum.Text = dgvAraclar.Rows[e.RowIndex].Cells["Durum"].Value.ToString().Trim();

                cmbSorumluSofor.Text = dgvAraclar.Rows[e.RowIndex].Cells["Sorumlu Şoför"].Value.ToString().Trim();
            }
        }
    }
}