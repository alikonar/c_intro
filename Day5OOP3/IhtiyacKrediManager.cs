using System;
using System.Collections.Generic;
using System.Text;

namespace Day5OOP3
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyac kredisi hesaplandı...");
        }
    }
}
