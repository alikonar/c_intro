using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tek tek yazmak yerine hepsini bir arrayde tanımlayacağız.

            string kurs1 = "Yazılım geliştirici";
            string kurs2 = "Programlaya Baslangic";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            //Array tanımlama aşşağıdaki gibidir.

            string[] kurslar = new string[] { "Yazılım geliştirici", "Programlamaya baslangic", "Java kursu", "Python", "C++", "Angular", "Temel seviye C şarp" };


            // aşşağıdaki for döngüsü ile hepsini ekrana yazdıracağız.

            for(int i= 0;i<kurslar.Length;i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            // For döngüsü kullanmadan "foreach" fonksiyonu ilede bu dizi döndürme işlemini yapabiliriz

            Console.WriteLine("*************************");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
                        
            }
            Console.WriteLine("**************************************************");
            Console.WriteLine(kurslar[5]);
         
        }
    }
}
