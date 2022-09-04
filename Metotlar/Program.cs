using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var item in urunler)
            {
                Console.WriteLine("ürün Adi :" + " " + item.Adi);
                Console.WriteLine("ürün Fiyati :" + " " + item.Fiyati);
                Console.WriteLine("ürün Açıklması :" + " " + item.Aciklama);
                Console.WriteLine("-------------");
            }


            Console.WriteLine("-----------------Metodlar------------------");

            SepeteManager sepeteManager = new SepeteManager();
            sepeteManager.Ekle(urun1);
            sepeteManager.Ekle(urun2);

            sepeteManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepeteManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepeteManager.Ekle2("Karpuz", "Diyarbakır Karpuz", 12, 8);
        }
    }
}
