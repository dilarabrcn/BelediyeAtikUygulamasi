using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelediyeAtikUygulamasi
{
    public partial class SifreForm : Form
    {

      
       
            public bool GirisBasarili { get; private set; } = false; ///

 
       
        public SifreForm()
        {
            InitializeComponent();
        }

        private void btnGirisY_Click(object sender, EventArgs e)
        {
            // yönetici şifresi
            if (txtSifreY.Text == "1234")
            {
                GirisBasarili = true; // değişkeni yukarıda tanımlı
                this.Close(); // sifre doğru, bu formu kapatır
            }
            else
            {
                MessageBox.Show("Hatalı Şifre! Giriş Yetkiniz Yok.", "Güvenlik", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSifreY.Clear(); // Şifreyi sil tekrar girilsin
            }
        }
    }
}
