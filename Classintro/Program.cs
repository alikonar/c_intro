using System;

namespace Classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ali";
            int yas = 21;

            Kurs kurs1 = new Kurs();
            kurs1.Kursadi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 69;

            Kurs kurs2= new Kurs();
            kurs2.Kursadi = "Python";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.izlenmeOrani = 25;
            
            Kurs kurs3= new Kurs();
            kurs3.Kursadi = "Angular";
            kurs3.Egitmen = "Engin Demiroğ";
            kurs3.izlenmeOrani = 58;

            //Console.WriteLine(kurs1.Kursadi+" "+kurs1.Egitmen);

            //Yukarıdaki kodu çalıştırmak yerine hızlıca bütün arrayleri dönebilecek bir array oluşturup foreach dönügüsüne sokuyoruz.

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs bilgi in kurslar)
            {
                Console.WriteLine(bilgi.Kursadi + ":" + bilgi.Egitmen + "-" + bilgi.izlenmeOrani);


            }



        }
    }

    class Kurs
    {
        public string Kursadi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }


    }
}
