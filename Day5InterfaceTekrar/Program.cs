using System;

namespace Day5InterfaceTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerManager serverManager = new ServerManager();
            serverManager.DoAdd( new MicrosoftServerLogService());
            Console.WriteLine("------------");
            serverManager.DoUpdate(new OracleServerLogService());
            Console.WriteLine("------------ ");
            serverManager.DoDelete(new LinuxServerLogService());




            
        }
    }
}
