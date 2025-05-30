using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05EscapeRoom_Urquizo_Brasburg_Liberman.Models;

namespace TP05EscapeRoom_Urquizo_Brasburg_Liberman.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
