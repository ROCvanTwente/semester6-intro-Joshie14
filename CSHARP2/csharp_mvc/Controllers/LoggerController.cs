using System.IO;
using System.Linq;
using csharp_mvc.Models.Logging;
using CSHARP2.Models;
using CSHARP2.Models.Logging;
using Microsoft.AspNetCore.Mvc;

namespace CSHARP2.Controllers
{
    public class LoggerController : Controller
    {
        private readonly ICustomLogger _logger;
        private readonly string _logFilePath;
        private const int MaxRecentLogs = 10;

        public LoggerController()
        {
            // Bepaal het volledige pad voor het logbestand
            _logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "logs.txt");

            // Zorg dat de directory bestaat
            Directory.CreateDirectory(Path.GetDirectoryName(_logFilePath));

            // Maak de loggers
            var fileLogger = new FileLogger(_logFilePath);
            var consoleLogger = new ConsoleLogger();

            // Combineer ze
            _logger = new CombinedLogger(fileLogger, consoleLogger);
        }

        public IActionResult Index()
        {
            var viewModel = new LogViewModel();

            // Laad recente logs
            if (System.IO.File.Exists(_logFilePath))
            {
                var allLogs = System.IO.File.ReadAllLines(_logFilePath);
                viewModel.RecentLogs = allLogs.Reverse().Take(MaxRecentLogs).ToList();
            }

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LogViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Log het bericht
                _logger.LogMessage(model.Message);

                // Geef een melding
                TempData["SuccessMessage"] = "Bericht succesvol gelogd!";

                // Reset formulier
                return RedirectToAction(nameof(Index));
            }

            // Bij fouten, laad opnieuw de logs
            if (System.IO.File.Exists(_logFilePath))
            {
                var allLogs = System.IO.File.ReadAllLines(_logFilePath);
                model.RecentLogs = allLogs.Reverse().Take(MaxRecentLogs).ToList();
            }

            return View(model);
        }
    }
}