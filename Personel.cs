using System;

namespace BelediyeAtikUygulamasi
{
    public class Personel
    {
        // Özellikler (Veritabanı sütunlarıyla birebir aynı)
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }
        public string GorevUnvani { get; set; }
        public decimal Maas { get; set; }
        public int CocukSayisi { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public string MedeniDurum { get; set; }
        public DateTime DogumTarihi { get; set; }

        // YAPICI METOT (CONSTRUCTOR) - KURAL 48
        // Nesne oluştuğu an verileri içine alır.
        public Personel(string tc, string ad, string soyad, string dept, string gorev, decimal maas, int cocuk, string tel, string posta, string adres, string medeni, DateTime dogum)
        {
            this.TC = tc;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Departman = dept;
            this.GorevUnvani = gorev;
            this.Maas = maas;
            this.CocukSayisi = cocuk;
            this.Telefon = tel;
            this.Eposta = posta;
            this.Adres = adres;
            this.MedeniDurum = medeni;
            this.DogumTarihi = dogum;
        }

        // Ekstra: Maaş Hesaplama Metodu (Clean Code & Business Logic)
        public decimal ToplamMaasHesapla()
        {
            return this.Maas + (this.CocukSayisi * 400);
        }
    }
}