﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 = 30 oldu.
            
            // int bir değer kısmıdır. değerler birbirlerine daha sonradan eşitlenebilir.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999 oldu.
            Console.WriteLine(sayilar1[2]);

            //101 102 adresleme olayını hatırla burası heap tarafı oluyor. Stack kısmı ile eşleştiriliyor.
            // !!! HATIRLAYAMAZSAN  Kampın 3. günü son dakikalara bak.!!! (https://www.youtube.com/watch?v=1j68gb1-qOw)




        }
    }
}