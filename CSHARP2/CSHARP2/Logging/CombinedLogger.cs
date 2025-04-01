using csharp_mvc.Models.Logging;

namespace CSHARP2.Models.Logging
{
    public class CombinedLogger : ICustomLogger
    {
        private readonly ICustomLogger[] _loggers;

        public CombinedLogger(params ICustomLogger[] loggers)
        {
            _loggers = loggers;
        }

        public void LogMessage(string message)
        {
            foreach (var logger in _loggers)
            {
                logger.LogMessage(message);
            }
        }
    }
}