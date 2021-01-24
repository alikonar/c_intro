using System;
using System.Collections.Generic;
using System.Text;

namespace Day5OOP3
{
    //Bir interface verdiğimiz interfacei kullanırsa aşşağıdaki metodu veya metodları içermek zorundandır.
    interface IKrediManager
    {
        // bir klasın sağlaması gereken yeteneklerin beyanıdır interface. İçerisinde sadece method ve proprtyler bulundurabilir.
        void Hesapla();
        void BiseyYap();

    }
}
