using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " İsimli Müşteri Kayıt Edildi");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "Adlı Müşteriler Listelendi");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + "Adlı Müşteriler Silindi");
        }
    }
}
