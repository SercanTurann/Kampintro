using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    internal class SepeteManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine(" Tebrikler. Sepete Eklendi !" + urun.Adi);
        }

        public void Ekle2(string urunAdi, string acikalama, double fiyat, int stokAdedi)
        {
            Console.WriteLine(" Tebrikler. Sepete Eklendi !" + urunAdi);
        }
    }
}
