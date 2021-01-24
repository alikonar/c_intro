using System;
using System.Collections.Generic;
using System.Text;

namespace Day5InterfaceTekrar
{
    class OracleServerLogService : ILoggerService
    {
        public void Add()
        {
            Console.WriteLine("Oracle Server Sisteme eklendi...");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Server sistemden çıkarıldı...");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Server başarıyla güncellendi...");
        }
    }
}
