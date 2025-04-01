using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyAnimalsMVC.Models;

namespace MyAnimalsMVC.Controllers;

public class HomeController : Controller
{
    // gemaakt dooor: arda
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return RedirectToAction("Index", "Dier");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}