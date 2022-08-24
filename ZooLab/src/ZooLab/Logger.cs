using System.Collections.Generic;
using System;

namespace ZooLab
{
    public static class Logger
    {
        public static List<string> Log { get; set; } = new List<string>(); 
        public static void WriteLog(string message)
        {
            Log.Add(message);
        }
    }
}
