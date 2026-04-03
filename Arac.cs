using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelediyeAtikUygulamasi
{
    public class Arac
    {
        // 1. ÖZELLİKLER (Veritabanındaki sütunlarla birebir uyumlu)
        public string AracNo { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KapasiteKG { get; set; }
        public string Plaka { get; set; }
        public string AracTipi { get; set; }
        public string RotaBilgisi { get; set; }
        public string Durum { get; set; }
        public string SorumluPersonelTC { get; set; } // Şoförü TC ile bağlayacağız

        // 2. YAPICI METOT (CONSTRUCTOR) - (PDF Kuralı: OOP Kullanımı)
        // Bu metot, "new Arac(...)" dediğimizde çalışır ve verileri içeri alır.
        public Arac(string no, string marka, string model, int kapasite, string plaka, string tip, string rota, string durum, string soforTC)
        {
            this.AracNo = no;
            this.Marka = marka;
            this.Model = model;
            this.KapasiteKG = kapasite;
            this.Plaka = plaka;
            this.AracTipi = tip;
            this.RotaBilgisi = rota;
            this.Durum = durum;
            this.SorumluPersonelTC = soforTC;
        }
    }
}
