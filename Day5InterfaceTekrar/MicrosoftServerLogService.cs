using System;
using System.Collections.Generic;
using System.Text;

namespace Day5InterfaceTekrar
{
    class MicrosoftServerLogService : ILoggerService
    {
        public void Add()
        {
            Console.WriteLine("Microsoft Server Sisteme eklendi...");
        }

        public void Delete()
        {
            Console.WriteLine("Microsoft Server Sistemden çıkarıldı...");
        }

        public void Update()
        {
            Console.WriteLine("Microsoft Server başarıyla güncellendi...");
        }
    }
}
