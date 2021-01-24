using System;

namespace Day5OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ali Konar
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.CustomerNo = "12345";
            musteri1.Name = "Ali";
            musteri1.LastName = "Konar";
            musteri1.TcNO = "292847618784";
            musteri1.Id = 1;


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerNo = "288842";
            musteri2.CompanyName = "Kodlama.io";
            musteri2.TaxNo = "888888882";

            Customer musteri3 = new GercekMusteri(); // referans no. Customer classı hem gercek hemde tuzel müsterinin referans numarasını tutabiliyor.
            Customer musteri4 = new TuzelMusteri();
           
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);//gercek müsteri
            customerManager.Add(musteri2);//tüzel müsteri


            


        }
    }
}
