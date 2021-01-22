using System;
using System.Collections.Generic;
using System.Text;

namespace Day4AGAINGenericIntro
{
    class MyList<T> //Küçüktür işaretini koyarak aslında çalışacak olduğuımuz özel bir tip class olduğunu belli ediyoruz.
    // T koymamızın nedeni istediğmiiz bir tipi belli etmek ve o an kullanmak.
    {

        T[] items; // Classta bir liste tutuyoruz kaydetmesi için. Ve bunun veri tipini T'ye eşitliyoruz. 
        // veri tipi belli  olduğunda otomatik olarak onu ya string yada int veya başka bir liste türüne çevirecek.
        public MyList() //Constructor. Classı bir yerde new yaptığında bu ctor otmatik çalışacaktır.
        // Newlediğin anda çalışan bloğa Constructor denir.
        {

            items = new T[0]; // new yaptın ve arrayi sıfır elemanlı olarak hemen verdin.
                              // arrayler referans tip olduğu için onları new yapman gerek.


        }



        public void Add(T item) // Ben T yerine ne verirsem istediğim elemanın türü o demektir.
        {

            T[] tempArray = items; // geçici dizi items'ın referans numarasını tutuyor. önceden eklenen elemanlar kaybolmuyor.
            // geçici dizi bizim önceki verdiğimiz elemanları tutuar.

            items = new T[items.Length+1]; // Arraye eleman eklemeden hemen önce arrayin eleman sayısını 1 arttırmamız gerek.
            // kendimize yeni bir referans alıyoruz burada.
            for (int i = 0; i < tempArray.Length; i++)
            {
                // bu döngü tempArray daki bütün elemanlar items'a tekrar aktarılana kadar devam edecek
                items[i] = tempArray[i]; // tempArraydeki i. elamanını itemsdaki i. elemanın yerine tekrar veriyoruz.

            }
            items[items.Length - 1] = item; // asıl eklenmek istenen elemanı şuan ekledik.

        }
    }
}
