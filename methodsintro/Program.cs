using System;

namespace methodsintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metotlar Tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır. 

            // Do not repeat yourself- DRY- Clean Code- Best Practice

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            product urun1 = new product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            product urun2 = new product();
            urun2.Adi = "Karpuuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarkabır karpuzu";

            product[] prod = new product[] {urun1, urun2 };

            
            // Type Safeting --- Tip Güvenliği
            foreach (var urunler in prod)
            {
                Console.WriteLine(urunler.Adi);
                Console.WriteLine(urunler.Fiyati);
                Console.WriteLine(urunler.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("---------------Methods---------------");

            //encapsulation- Class içine yazmamıza rağmen hata vermedi. Class içindekileri her zaman ekleyebilir ve istedğimiz zaman kullanabiliriz.

            sepetManager sepetManager = new sepetManager();
            
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,500);
            sepetManager.Ekle2("Üzüm", "Yeşil üzüm", 15,1244);
            
           






        }
    }
}



