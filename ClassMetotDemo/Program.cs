using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Ad = "Sercan";
            musteri.SoyAd = "Turan";
            musteri.Yas = 32;
            musteri.TcKimlikNo = "12345678919";
            musteri.Meslek = "Yazılım Destek";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Sercan2";
            musteri2.SoyAd = "Turan2";
            musteri2.Yas = 32;
            musteri2.TcKimlikNo = "12345678919";
            musteri2.Meslek = "Yazılım Destek2";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri);
            musteriManager.MusteriListele(musteri);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriSil(musteri);
            musteriManager.MusteriSil(musteri2);


        }
    }
}
