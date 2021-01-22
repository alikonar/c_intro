using System;
using System.Collections.Generic;

namespace Day4GenericsYoutube
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Bolu");
            Console.WriteLine(sehirler.Count);
            

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Giresun");
            sehirler2.Add("Siva4s");
            sehirler2.Add("Sivas3");
            sehirler2.Add("Sivas2");
            sehirler2.Add("Sivas1");
            Console.WriteLine(sehirler2.Count);









        }


        class MyList<T>
        {
            T[] Array;
            T[] tempArray;
            public MyList()
            {
                Array = new T[0];
            }
            public void Add(T item)
            {
                tempArray = Array;
                Array = new T[Array.Length + 1];
                for (int a = 0; a < tempArray.Length; a++)
                {
                    Array[a] = tempArray[a];

                }
                Array[Array.Length - 1] = item;
            }



            public int Count
            {
                get { return Array.Length; }
               
            }



        }
    }
}
