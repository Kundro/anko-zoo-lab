using System;

namespace ZooLab
{
    public class MockConsole : IConsole
    {
        public void Write(string message)
        {
            Logger.WriteLog(message);
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Logger.WriteLog(message);
            Console.WriteLine(message);
        }
    }
}
