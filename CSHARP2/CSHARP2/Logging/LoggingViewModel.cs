using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CSHARP2.Models
{
    public class LogViewModel
    {
        [Required(ErrorMessage = "Een bericht is verplicht")]
        [Display(Name = "Log Bericht")]
        public string Message { get; set; }

        public List<string> RecentLogs { get; set; } = new List<string>();
    }
}