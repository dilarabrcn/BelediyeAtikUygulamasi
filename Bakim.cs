using System;

namespace BelediyeAtikUygulamasi
{
    public class Bakim
    {
        public string AracPlaka { get; set; }
        public string BakimTipi { get; set; }
        public decimal Maliyet { get; private set; }

        public Bakim(string plaka, string tip)
        {
            AracPlaka = plaka;
            BakimTipi = tip;
            UcretHesapla();
        }

        private void UcretHesapla()
        {
            if (BakimTipi == "Standart") Maliyet = 5000m;
            else if (BakimTipi == "Ağır") Maliyet = 12000m;
            else Maliyet = 0;
        }
    }
}