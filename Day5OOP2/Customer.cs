using System;
using System.Collections.Generic;
using System.Text;

namespace Day5OOP2
{
    // Classların 2 görevi vardır. 1- Özellikler tutar.2- Operasyonlar tutar.
    // 2 görev bi arada olamaz ama.
    class Customer
    {
        //****eğerki bir nesnede bir değeri kullanmak zorunda değilsen o değeri class içinde kullanma.
        // Şirketi olmayan müşteriler ve şirketi olan müşteri verileri karışabilir  birbirine.


        //BURASI BİR BASE SINIFDIR.
        public int Id { get; set; }
        public string CustomerNo { get; set; }


        //Gerçek Müşteri -  Tüzel Müşteri
        // SOLID - Yazılım geliştirme tekniğidir.
        // SOLID 

    }
}
