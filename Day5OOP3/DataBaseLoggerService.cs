using System;
using System.Collections.Generic;
using System.Text;

namespace Day5OOP3
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
