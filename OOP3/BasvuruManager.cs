using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BasvuruManager
    {

        //Method injection
        public void BasvuruYap(IKrediManager krediManager , ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            // KonutKrediManager konutKrediManager = new KonutKrediManager(); // Bu kullanım yanlış tüm başvural konut kredisi üzerinden değerlendirilir.
            //konutKrediManager.Hesapla();

            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var item in krediler)
            {
                item.Hesapla();
            }
        }
    }
}
