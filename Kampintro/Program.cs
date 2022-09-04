using System;

namespace Kampintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Katagoriler";
            int ogrenciSatyisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayaraları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            Console.WriteLine(kategoriEtiketi);


        }
    }
}


