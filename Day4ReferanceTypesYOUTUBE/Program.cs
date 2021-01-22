using System;

namespace Day4ReferanceTypesYOUTUBE
{
    class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, enum, boolean vb. sayısal tipte olanlar değer tip olarak adlandırılır.
            // value types (değer tip)
            // değer tiplerle ilgili herşey stack kısımda çalışır.

            int a = 10;
            int b = 2055;

            a = b;
            b = 100;
            Console.WriteLine("A sayısı : "+a);

            //array, class ,interface... vb. olanlar Referans tipte verilerdir.
            // Referance Types.
            int[] sayilar1 = new int[] { 1, 2, 3, 4 };
            int[] sayilar2 = new int[] { 10, 20, 30, 40 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine("sayilar1 0. indisi : "+sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ali";
            person2 = person1;
            person1.FirstName = "Melek";
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Furkan";
            customer.CreditCardNumber = 11119992;
            Employe employe = new Employe();
            employe.FirstName = "Haluk";

            Person person3 = customer; // Aşşağıda classlarda atama yaptığımız için aslında burada biribirine eşitleme yapabiliriz.
            
            
            Console.WriteLine(((Customer)person3).CreditCardNumber); // person3 üzerinden card numarsına boxing yaparak ulaşabiliriz.
            // boxing yaparak geçtik.

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);
            personManager.Add(employe);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    // base class. Temel sınıf Person'dur. 
    class Customer:Person
    {
        public int CreditCardNumber { get; set; }

    }
    class Employe:Person
    {
        public int EmloyeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person) // parametre olarak base metod yani Person kullanığımız için yukarıda customerda kullansak Employee de kullansak bize kızmayacaktır.
        {
            Console.WriteLine(person.FirstName);
        }
        

    }
}
