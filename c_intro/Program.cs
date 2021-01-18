using System;

namespace c_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety- tip güvenliği
            // do not repeat yourself

            // deger tutucu, alias. Değişmeyen etiket.
            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            int ogrenciSayisi = 32000; //Tam sayi veri tipi.
            double faizOrani = 1.49; //Float veri tipi.
            bool sistemeGiris = true; //boolean veri tipi.1 ve 0 gibi.
            double dolarDun = 7.96;
            double dolarBugun = 7.96;
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış oku");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış oku");

            }
            else
            {
                Console.WriteLine("Dolar aynı değişmedi.");
            }

            if(sistemeGiris==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");

            }

            Console.WriteLine(kategoriEtiketi);

            
         
        }
    }
}
