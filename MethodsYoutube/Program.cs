using System;
using System.Linq;

namespace MethodsYoutube
{
    class Program
    {
        static void Main(string[] args)
        {

            //Add();
            //var result = Add2(39);

            //int no1 = 20;
            //int no2 = 100;
            //var result2 = Add3(ref no1, no2); // ref keywordunu her iki tarafada göstermemiz gerekmekte.
            //Console.WriteLine(result2);
            //Console.WriteLine(no1);

            //Console.WriteLine(Multiply(2, 4));
            //Console.WriteLine(Multiply(2,4,9));

            Console.WriteLine(Add4(2, 3, 4, 5, 6, 7, 8, 11));
            Console.ReadLine();
        }

        // -----Basit bir method tanımı-------
        static void Add()
        {
            Console.WriteLine("Added");
        }

        // Alt kısma static int ile bir fonksiyon ekledik. İnt kısmı normalde void'di ama int olması gerekir.
        
        // ---------------Default Parameter kullanımı..------------------
        static int Add2(int no0,int no1=99, int no2=30) // no1 ve no2 ye yaptığımız defaultt parametredir. Eğer no2 verilmezse 30 kabul edilir.
        {// //default değerleri methodların en son kısmına verilir.
            // Var değişkenine kaydettik işlemi.
            var result = no1 + no2 + no0;
            return result;
        }

        // -----------*ref keyword*----------*out keyword*------------
        static int Add3 (ref int no1,int no2) // geçerli bir süreç için ref keywordunu kullanabiliriz. Fonksiyon içerisindeki tanımladığımız değeri yukarıya taşıyacaktır.
        {   // ((ref)) keywordu kullandıktan sonra yukarıda tanımadığımız no1 içinde değer değişecektir. 20 olan değer 30 olacaktır.Fakat en başta değer tanımlanmalıdır.
            // ((out)) keywordude aynı şekilde kullanabiliriz. Tek farkları no1 için herhangi bir tanımalama yapılmasada olur. ref keywordunde ise kesninlikle ve kesinlikle bir tanım yapılmaılıdır.
            // ((out))2 bu keywordde Add3 içindeki no1 tanımlamazsak bu sefer ref'in tam tersi olşarak bir sorun çıkartır ve çalışmaz. 
            no1 = 30;
            return no1 + no2;
        }

        // --------------Method Overloading ----------------

        static int Multiply(int no1, int no2)
        {
            return no1 * no2;
        }

        // yukarıda 2 değer tanımladık fonksiyonda fakat 3 yapmak isteseydik bu şekilde aynı isme sahip yeni bir method oluşturabiliriz.Methodlar buna razı olurlar.
        static int Multiply(int no1, int no2, int no3)  
        {
            return no1 * no2 * no3;
        }

        //-----------------params keyword-------------------

        static int Add4(params int[] numbers)
        {// birden fazla sayı eklenmek istendiğinde overloading yerine toplama işlemi için params ile bir dizi oluşturup .Sum() fonksiyonunu kullanabiliriz.
            return numbers.Sum(); // Sum() kullanmak için >> using System.Linq;  ekle...
        }

    }   
}
