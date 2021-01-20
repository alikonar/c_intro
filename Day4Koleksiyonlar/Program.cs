using System;
using System.Collections.Generic;

namespace Day4Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {
            //"Ali","Melek","AFZ","Barış"};

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //// alttaki yöntemi yaparak yukarıdaki elamanları kaybedersin.
            //isimler = new string[5];
            //isimler[4] = "Kenan";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string> { "Ali", "Melek", 
                "AFZ", "Barış" };

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Kenan");
            Console.WriteLine(isimler2[4]);


            int[] integher = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            int b = integher.Length;
            Console.WriteLine(b);



            

           

        }
    }
}
