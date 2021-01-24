using System;
using System.Collections.Generic;
using System.Text;

namespace Day5OOP2
{
    //Coorporate-Tüzel Müşteri.
    //Miras -- Inheritance : bundan sonra.
    //Inheritance= Müşterinin içindeki tüm özellikler diğerlerindende var kabul edilir.

    class TuzelMusteri:Customer
    {
        
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }

    }
}
