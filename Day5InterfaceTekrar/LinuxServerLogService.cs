using System;
using System.Collections.Generic;
using System.Text;

namespace Day5InterfaceTekrar
{
    class LinuxServerLogService : ILoggerService
    {
        public void Add()
        {
            Console.WriteLine("Linux Server sisteme eklendi...");
        }

        public void Delete()
        {
            Console.WriteLine("Linux Server sistemden çıkarıldı...");
        }

        public void Update()
        {
             Console.WriteLine("Linux Server başarıyla güncellendi...");
        }
    }
}
