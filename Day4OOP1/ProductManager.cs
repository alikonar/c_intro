using System;
using System.Collections.Generic;
using System.Text;

namespace Day4OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" eklendi.");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" güncellendi.");
        }
        
        
        // ..void >> bu fonksiyonda hafızaya bir şey kaydetmezsin.
        // ..int  >> bu fonskiyonda hafızaya kaydetip başka yerde kullanırsın.


      
    }


}
