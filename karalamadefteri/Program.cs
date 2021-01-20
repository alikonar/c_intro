using System;

namespace karalamadefteri
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] deneme1 = new string[] { "Ali", "Melek", "Afz", "Barış" };
            string[] deneme2 = new string[] { "Şan", "Şöhret", "Para" };

            deneme1[0] = deneme2[1];
            Console.WriteLine(deneme1[0]);
            deneme2[2] = deneme1[3];
            Console.WriteLine(deneme2[2]);

            int a = 22;
            int b = 18;
            int c = 24;

           
            a = b = c;
            
            
            Console.WriteLine(a);
            Console.WriteLine(b);


          
            


        }
    }
}
