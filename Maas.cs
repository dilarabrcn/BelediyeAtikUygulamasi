using System;

namespace BelediyeAtikUygulamasi
{
    public class Maas
    {
        public decimal TabanMaas { get; set; }
        public int CocukSayisi { get; set; }
        public decimal ToplamMaas { get; private set; }

        public Maas(decimal tabanMaas, int cocukSayisi)
        {
            TabanMaas = tabanMaas;
            CocukSayisi = cocukSayisi;
            MaasHesapla();
        }

        private void MaasHesapla()
        {
            decimal cocukYardimi = CocukSayisi * 400;
            ToplamMaas = TabanMaas + cocukYardimi;
        }
    }
}