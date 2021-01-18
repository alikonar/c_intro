using System;
using System.Collections.Generic;
using System.Text;

namespace methodsintro
{
    class sepetManager
    {
        //naming convention
        // Syntax farklıdır bütün dillerde. Ama yöntemler aynıdır.
        public void Ekle(product urun) 
        {
            Console.WriteLine("Sepete Eklendi >>"+ urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: "+ urunAdi);

        }
    }
}
