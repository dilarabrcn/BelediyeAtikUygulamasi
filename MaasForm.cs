using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BelediyeAtikUygulamasi
{
    public partial class MaasForm : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BelediyeAtikDB_D;Integrated Security=True");

        public MaasForm()
        {
            InitializeComponent();
        }

        private void MaasForm_Load(object sender, EventArgs e)
        {
            // Tarih ayarları yap
            txtYil.Text = DateTime.Now.Year.ToString();
            if (cmbAy.Items.Count == 0)
                for (int i = 1; i <= 12; i++) cmbAy.Items.Add(i.ToString());
            cmbAy.Text = DateTime.Now.Month.ToString();

            // Sayfa açılır açılmaz verileri getir
            PersonelListesiniGetir();
        }

        void PersonelListesiniGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sorgu = @"
                    SELECT 
                        P.TC, 
                        P.AD, 
                        P.SOYAD, 
                        P.DEPARTMAN, 
                        P.GorevUnvani, 
                        P.CocukSayisi, 
                        P.MAAS as ToplamMaas,
                        ISNULL(M.Durum, 'Ödenmedi') as OdemeDurumu,
                        M.OdemeTarihi
                    FROM Personeller P
                    LEFT JOIN MaasOdemeleri M ON P.TC = M.PersonelTC 
                        AND M.OdenenAy = @ay AND M.OdenenYil = @yil";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                da.SelectCommand.Parameters.AddWithValue("@ay", cmbAy.Text);
                da.SelectCommand.Parameters.AddWithValue("@yil", txtYil.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMaaslar.DataSource = dt;
                baglanti.Close();

                dgvMaaslar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri getirme hatası: " + ex.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        //  ÖDEME BUTONU ---
        private void btnTumunuOde_Click(object sender, EventArgs e)
        {
            // 1. TARİH KESİN KONTROLÜ (PDF Ayın 15'inde ödenir)
            if (DateTime.Now.Day != 15)
            {
                MessageBox.Show("HATA: Maaş ödemeleri yalnızca ayın 15'inde yapılabilir. Bugün ayın " + DateTime.Now.Day.ToString() + "'i.",
                                "Tarih Engeli", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; // 15'i değilse burada durur.
            }

            // 2. Muhasebe Yöneticisi Yetki Kontrolü
            if (string.IsNullOrEmpty(txtYoneticiTC.Text) || !MuhasebeYoneticisiMi(txtYoneticiTC.Text))
            {
                MessageBox.Show("Bu işlemi yalnızca 'Muhasebe Yöneticisi' yapabilir!");
                return;
            }

            try
            {
                // BAĞLANTIYI DÖNGÜDEN ÖNCE TEK BİR KEZ AÇIYORUZ
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                int odenenSayisi = 0;
                foreach (DataGridViewRow satir in dgvMaaslar.Rows)
                {
                    if (satir.Cells["TC"].Value == null) continue;

                    string tc = satir.Cells["TC"].Value.ToString();
                    string adSoyad = satir.Cells["AD"].Value.ToString() + " " + satir.Cells["SOYAD"].Value.ToString();
                    decimal taban = Convert.ToDecimal(satir.Cells["ToplamMaas"].Value);
                    int cocuk = Convert.ToInt32(satir.Cells["CocukSayisi"].Value);

                    // BAĞLANTIYI KAPATMAYAN KONTROL METODUNU ÇAĞIRIYORUZ
                    if (HizliOdendiKontrolu(tc, cmbAy.Text, txtYil.Text)) continue;

                    // OOP Hesaplama: Maas sınıfı (Constructor kullanımı zorunludur)
                    Maas m = new Maas(taban, cocuk);

                    // Ödemeyi Kaydet
                    string sql = @"INSERT INTO MaasOdemeleri (PersonelTC, AdSoyad, OdenenAy, OdenenYil, OdenenTutar, OdemeTarihi, Durum) 
                                   VALUES (@tc, @adsoyad, @ay, @yil, @tutar, GETDATE(), @durum)";

                    SqlCommand cmd = new SqlCommand(sql, baglanti);
                    cmd.Parameters.AddWithValue("@tc", tc);
                    cmd.Parameters.AddWithValue("@adsoyad", adSoyad);
                    cmd.Parameters.AddWithValue("@ay", cmbAy.Text);
                    cmd.Parameters.AddWithValue("@yil", txtYil.Text);
                    cmd.Parameters.AddWithValue("@tutar", m.ToplamMaas);
                    cmd.Parameters.AddWithValue("@durum", "Ödendi");

                    cmd.ExecuteNonQuery();
                    odenenSayisi++;
                }

                // TÜM İŞLEM BİTİNCE KAPATIYORUZ
                baglanti.Close();
                MessageBox.Show($"{odenenSayisi} personelin maaşı ödendi.");

                // Tabloyu güncelle
                PersonelListesiniGetir();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonelListesiniGetir();
        }

        // --- YARDIMCI KONTROLLER ---

        bool MuhasebeYoneticisiMi(string tc)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM Personeller WHERE TC=@tc AND GorevUnvani LIKE '%Muhasebe Yöneticisi%'", baglanti);
            cmd.Parameters.AddWithValue("@tc", tc);
            int sonuc = (int)cmd.ExecuteScalar();
            baglanti.Close();
            return sonuc > 0;
        }

        // DÖNGÜ İÇİNDE BAĞLANTIYI AÇIK TUTAN METOT
        bool HizliOdendiKontrolu(string tc, string ay, string yil)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM MaasOdemeleri WHERE PersonelTC=@tc AND OdenenAy=@ay AND OdenenYil=@yil", baglanti);
            cmd.Parameters.AddWithValue("@tc", tc);
            cmd.Parameters.AddWithValue("@ay", ay);
            cmd.Parameters.AddWithValue("@yil", yil);
            int sonuc = (int)cmd.ExecuteScalar();
            return sonuc > 0;
        }
    }
}