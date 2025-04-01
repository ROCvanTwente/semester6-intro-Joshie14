using csharp_mvc.Models.Logging;
using System;

namespace CSHARP2.Models.Logging
{
    public class ConsoleLogger : ICustomLogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}