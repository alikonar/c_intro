using System;
using System.Collections.Generic;
using System.Text;

namespace Day5OOP3
{
    class BasvuruManager
    {
        // Method Injection. Yani hem kredimanager hemde logservice enjekte ettik tek methodda.
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {


            //Basvuran bilgilerini değerlendirme
            //


            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesi(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }

        
    }
}
