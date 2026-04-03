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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {

            SifreForm frmGiris = new SifreForm();
            frmGiris.ShowDialog(); // Şifre penceresini açar ve cevap gelene kadar ana formu bekletir

            if (frmGiris.GirisBasarili) 
            {
                PersonelForm frmPersonel = new PersonelForm();
                frmPersonel.Show();
            }

        }

        private void btnArac_Click(object sender, EventArgs e)
        {
            AracForm frm = new AracForm();
            frm.ShowDialog();
        }

        private void btnAtik_Click(object sender, EventArgs e)
        {
            AtikForm frm = new AtikForm();
            frm.ShowDialog();
        }

        private void btnBakim_Click(object sender, EventArgs e)
        {
            BakimForm frm = new BakimForm();
            frm.ShowDialog();
        }

        private void btnMaas_Click(object sender, EventArgs e)
        {
            MaasForm frm = new MaasForm();
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
