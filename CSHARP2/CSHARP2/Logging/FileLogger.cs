using csharp_mvc.Models.Logging;
using System;
using System.IO;

namespace CSHARP2.Models.Logging
{
    public class FileLogger : ICustomLogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void LogMessage(string message)
        {
            try
            {
                string logEntry = $"{DateTime.Now}: {message}";
                File.AppendAllText(_filePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fout bij schrijven naar logbestand: {ex.Message}");
            }
        }
    }
}