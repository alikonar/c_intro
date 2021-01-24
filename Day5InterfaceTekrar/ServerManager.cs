namespace Day5InterfaceTekrar
{
    class ServerManager
    {
        public void DoAdd(ILoggerService loggerService)
        {
            loggerService.Add();
            
        }
        public void DoDelete(ILoggerService loggerService)
        {
            loggerService.Delete();

        }
        public void DoUpdate(ILoggerService loggerService)
        {
            loggerService.Update();
        }


    }
}
