using System;

namespace ZooLab
{
    public class MockConsole : IConsole
    {
        public void WriteLine(string message)
        {
            Logger.WriteLog(message);
            Console.WriteLine(message);
        }
    }
}
