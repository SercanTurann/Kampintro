using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proggramlamaya başlamak için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Proggramlamaya başlamak için temel kurs", "java", "Python","C++" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
