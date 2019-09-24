using DK.BusinessLogic.Interfaces;
using Microsoft.Extensions.Logging;

namespace DK.BusinessLogic.Services
{
    public class LogService<T> : ILogService<T>
    {
        private readonly ILogger<T> _logger;
        public LogService(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }

        public void LogWarning(string message, params object[] args)
        {
            _logger.LogWarning(message, args);
        }

        public void LogInformation(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }
    }
}
