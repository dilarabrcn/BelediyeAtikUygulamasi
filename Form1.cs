using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace BelediyeAtikUygulamasi
{
    public partial class Form1 : Form

    {
       

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BelediyeAtikDB_D;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                
                // TC sütunu kullanıcı adı yerine geçecek.

                SqlCommand komut = new SqlCommand("Select * From Personeller where TC=@p1 and Sifre=@p2", baglanti);

                // Formdaki txtAd kutusuna TC yazılacak, txtSifre'ye şifre.
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı! Sisteme Hoşgeldiniz.");


                    AnaSayfa anaSayfaFormu = new AnaSayfa(); // Yeni form
                    anaSayfaFormu.Show();                    // Yeni formu aç
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Hatalı TC veya Şifre!");
                }
                baglanti.Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu: " + hata.Message);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void txtAd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Down)
            {
                txtSifre.Focus();
            }
         
        }

        private void txtSifre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Up)
            {
                txtAd.Focus();
            }
        }
    }
}
