using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelediyeAtikUygulamasi
{
    public partial class PersonelForm : Form
    {
        // HAFIZA DEĞİŞKENİ: Kimin güncelleneceğini unutmamak için şart.
        string hafizadakiTC = "";

        public PersonelForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BelediyeAtikDB_D;Integrated Security=True");

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            btnListele.PerformClick();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From Personeller", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPersonel.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex) { MessageBox.Show("Listeleme Hatası: " + ex.Message); }
        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Grid'den TC'yi alırken Trim() ile boşlukları siliyoruz
                hafizadakiTC = dgvPersonel.Rows[e.RowIndex].Cells["TC"].Value.ToString().Trim();

                txtTC.Text = hafizadakiTC;
                txtAD.Text = dgvPersonel.Rows[e.RowIndex].Cells["AD"].Value.ToString().Trim();
                txtSOYAD.Text = dgvPersonel.Rows[e.RowIndex].Cells["SOYAD"].Value.ToString().Trim();
                cmbGorev.Text = dgvPersonel.Rows[e.RowIndex].Cells["GorevUnvani"].Value.ToString();
                txtMaas.Text = dgvPersonel.Rows[e.RowIndex].Cells["MAAS"].Value.ToString();
                txtCocuk.Text = dgvPersonel.Rows[e.RowIndex].Cells["CocukSayisi"].Value.ToString();
                txtTEL.Text = dgvPersonel.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
                txtPosta.Text = dgvPersonel.Rows[e.RowIndex].Cells["Eposta"].Value.ToString();
                txtAdres.Text = dgvPersonel.Rows[e.RowIndex].Cells["Adres"].Value.ToString();
                txtMedeniDurum.Text = dgvPersonel.Rows[e.RowIndex].Cells["MedeniDurum"].Value.ToString();

                var tarih = dgvPersonel.Rows[e.RowIndex].Cells["DogumTarihi"].Value;
                txtDogumTarihi.Text = tarih != null ? tarih.ToString() : "";
            }
        }

        // --- CHATGPT'NİN "KOYDUĞU" O MEŞHUR GÜNCELLEME BUTONU ---
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hafizadakiTC))
            {
                MessageBox.Show("Lütfen önce listeden bir personel seçin!");
                return;
            }

            decimal maas;
            int cocuk;
            if (!decimal.TryParse(txtMaas.Text, out maas) || !int.TryParse(txtCocuk.Text, out cocuk))
            {
                MessageBox.Show("Maaş veya çocuk sayısı hatalı!");
                return;
            }

            // ÇOCUK ZAMMI HESABI
            decimal finalMaas = maas + (cocuk * 400);

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // LTRIM ve RTRIM: SQL'in eklediği tüm boşlukları traşlayıp TC'yi tam bulur.
                // Sorguda CocukSayisi=@cocuk kısmının olduğundan emin oluyoruz
                string sorgu = @"UPDATE Personeller SET 
                        AD = @ad, 
                        SOYAD = @soyad, 
                        MAAS = @maas, 
                        CocukSayisi = @cocuk, 
                        GorevUnvani = @gorev,
                        Telefon = @tel,
                        Eposta = @posta,
                        Adres = @adres,
                        MedeniDurum = @medeni
                        WHERE LTRIM(RTRIM(TC)) = @tc";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                // PARAMETRELER:
                komut.Parameters.AddWithValue("@ad", txtAD.Text.Trim());
                komut.Parameters.AddWithValue("@soyad", txtSOYAD.Text.Trim());
                komut.Parameters.AddWithValue("@maas", finalMaas); // Hesaplanan maaş
                komut.Parameters.AddWithValue("@cocuk", cocuk);    // İŞTE BURASI! (Veritabanındaki sütuna giden değer)
                komut.Parameters.AddWithValue("@gorev", cmbGorev.Text);
                komut.Parameters.AddWithValue("@tel", txtTEL.Text.Trim());
                komut.Parameters.AddWithValue("@posta", txtPosta.Text.Trim());
                komut.Parameters.AddWithValue("@adres", txtAdres.Text.Trim());
                komut.Parameters.AddWithValue("@medeni", txtMedeniDurum.Text.Trim());
                komut.Parameters.AddWithValue("@tc", hafizadakiTC.Trim());

                int etkilenen = komut.ExecuteNonQuery();
                baglanti.Close();

                if (etkilenen > 0)
                {
                    MessageBox.Show("Güncelleme Başarılı ✅ Değişiklikler kalıcı oldu.");
                    btnListele.PerformClick();
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı! (TC: " + hafizadakiTC + ")");
                }
            }
            catch (Exception ex)
            {
                baglanti.Close();
                MessageBox.Show("Sistem Hatası: " + ex.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Ekleme kodun zaten çalışıyor, aynen kalabilir...
            // (Buraya senin eski Ekle kodunu koyabilirsin)
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Silme işlemine de aynı LTRIM/RTRIM zırhını ekleyelim garanti olsun
            if (string.IsNullOrEmpty(txtTC.Text)) return;
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Personeller Where LTRIM(RTRIM(TC))=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtTC.Text.Trim());
                komut.ExecuteNonQuery();
                baglanti.Close();
                btnListele.PerformClick();
                MessageBox.Show("Kayıt silindi.");
            }
            catch (Exception ex) { baglanti.Close(); MessageBox.Show(ex.Message); }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            // Arama kodun...
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            string sorgu = "Select * From Personeller where TC Like '%" + textBox1.Text + "%' Or AD Like '%" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPersonel.DataSource = dt;
            baglanti.Close();
        }
    }
}