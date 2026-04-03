using System;

namespace BelediyeAtikUygulamasi
{
    public class Atik
    {
        public string AracPlaka { get; set; }
        public string AtikTuru { get; set; }
        public decimal MiktarKG { get; set; } // Gelen
        public decimal DonusturulenMiktar { get; private set; } // Çıktı
        public decimal VerimYuzdesi { get; private set; } // %
        public decimal BirimFiyat { get; private set; }
        public decimal ToplamKazanc { get; private set; }

        public Atik(string plaka, string tur, decimal miktar)
        {
            AracPlaka = plaka;
            AtikTuru = tur;
            MiktarKG = miktar;

            Hesapla(); // Tüm hesaplamaları yap
        }

        private void Hesapla()
        {
            // 1. FİYAT HESAPLAMA (PDF Madde 35-39)
            switch (AtikTuru)
            {
                case "Plastik": BirimFiyat = 4.0m; break;
                case "Kağıt": BirimFiyat = 2.0m; break;
                case "Metal": BirimFiyat = 6.0m; break;
                case "Cam": BirimFiyat = 1.0m; break;
                case "Organik": BirimFiyat = 0.5m; break;
                default: BirimFiyat = 0; break;
            }
            ToplamKazanc = MiktarKG * BirimFiyat;

            // 2. VERİM VE DÖNÜŞTÜRÜLEN MİKTAR HESABI
            // (Her atığın dönüşüm oranı farklıdır, varsayılan oranlar ekledik) VARSAYILAN MECBUR
            decimal oran = 0;
            switch (AtikTuru)
            {
                case "Metal": oran = 0.95m; break; // %95 kurtarılır
                case "Plastik": oran = 0.90m; break; // %90
                case "Cam": oran = 0.98m; break; // %98
                case "Kağıt": oran = 0.85m; break; // %85
                case "Organik": oran = 0.60m; break; // %60 (Gübre vb.)
            }

            DonusturulenMiktar = MiktarKG * oran;

            // PDF Formülü: (Dönüştürülen / Gelen) * 100
            if (MiktarKG > 0)
                VerimYuzdesi = (DonusturulenMiktar / MiktarKG) * 100;
            else
                VerimYuzdesi = 0;
        }
    }
}