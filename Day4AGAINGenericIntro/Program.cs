using System;

namespace Day4AGAINGenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            MyList<string> isimler = new MyList<string>(); // genericsleri bu şekilde kullanıyoruz.
            // yukarıda string dediğimiz yerde T verdiğimiz string olarak değişiyor.

            isimler.Add("Ali");
            
            
            
        }
    }
}
