using System;

namespace eticaretodev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classı tanımladıktan sonra o Class'a ait bütün verileri tanımlıyoruz. İsmine, ülkesine ve Fiyatına göre verileri belli ediyoruz.
            
            //Product 1
            Ticaret product1 = new Ticaret();
            product1.productName = "Apple iPhone 12 Pro";
            product1.Country = "U.S.A.";
            product1.priceProduct = 699;
            //Product 2
            Ticaret product2 = new Ticaret();
            product2.productName = "Philips Mechanical Keyboard ";
            product2.Country = "Sweeden";
            product2.priceProduct = 59;
            //Product 3
            Ticaret product3 = new Ticaret();
            product3.productName = "Filter Coffe";
            product3.Country = "Africa";
            product3.priceProduct = 19;
            //Product 4
            Ticaret product4 = new Ticaret();
            product4.productName = "Sony Bluetooth Headset";
            product4.Country = "England";
            product4.priceProduct = 39;
            //Product 5
            Ticaret product5 = new Ticaret();
            product5.productName = "C# Learning Book";
            product5.Country = "Turkey";
            product5.priceProduct = 5;

            //Oluşturduğumuz verileri bir dizi içine kaydediyoruz.
            Ticaret[] products = new Ticaret[] { product1, product2, product3, product4, product5 };



            Console.WriteLine("-------------------foreach-------------------");
            foreach (Ticaret prod in products)
            {
                Console.WriteLine(prod.productName+"--- "+"Made in "+prod.Country+"    "+"Price :"+prod.priceProduct+"  Dollar");
                //foreach döngüsü ile bu şekilde verilerimizi çağırıyoruz.
            }
            Console.WriteLine("--------------------FOR------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productName + "--- " + "Made in " + products[i].Country + "    " + "Price :" + products[i].priceProduct + "  Dollar");

                // for döngüsü ile i int verisini sürekli 1 arttırarak i. elemanı özellikleriyle beraber getir diyoruz.
            }

            Console.WriteLine("---------------------While------------------");
            int p = 0; // whilein görebileceği bir int tanımlıyoruz.
            while (p<products.Length)
            {
                Console.WriteLine(products[p].productName + "--- " + "Made in " + products[p].Country + "    " + "Price :" + products[p].priceProduct + "  Dollar");
                
                // for döngüsüne benzer bir şekilde burdada p. elemeanı çağır diyoruz.

                p++; // eğer p++ yapmazsak p değeri aynı kalacağından sonsuz bir döngü oluştururuz.
            }


          
        }


    }
    class Ticaret // Bir class oluşturduk. Bu classta hangi veri tiplerinin olacğını ve isimlerini belirttik.
    {
        public string productName { get; set; }
        public int priceProduct { get; set; }
        public string Country { get; set; }


    }
}
