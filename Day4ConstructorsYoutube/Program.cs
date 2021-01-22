using System;

namespace Day4ConstructorsYoutube
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Constructor= bir classı newlediğin zaman çalışan bloktur.
            //Constructor= Yapıcı blok demektir.

            Customer customer1 = new Customer { Id = 1, Name = "Ali", SurName = "Konar", City = "Istanbul" };

            Customer customer2 = new Customer(2, "Melek", "Konar", "Edirne");

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Furkan";
            customer3.SurName = "Zehir";
            customer3.City = "Trabzon 61";

            Console.WriteLine(customer2.Name);



            


          
        }
        static void Method(int id, string name,string surname,string city)
        {

        }
    }
    class Customer
    {
        
        public Customer()
        {
            //Bu ctor ile overloading yaptık. Aynı fonksiyondan 2 tane çağırdık.
            //Bu ctor ile customer1 tanımlamasını yapabilir hale getirdik.

        }
        // default constructor denir boş olan bir ctor'a.
        public Customer(int id, string name,string surName,string city) //Ctorlar bir metod gibi çalışır. 
        {
            //Bu ctor ile Customer2 tanımlaması yapabilir hale geldik.
            Name = name;
            SurName = surName;
            Id = id;
            City = city;
            
            //Parametreleri classtaki paramaetreler ile eşitlemen lazımki verileri okuyabil.

            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string City { get; set; }


    }
}
