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

    public IActionResult CompararRespuesta (string RespuestasUsuario)
    {
        //hacer un objeto para despues con ese objeto subir las cosas a seccion 
        ViewBag.VBCompResp = JuegoEscape.compararRespuesta(RespuestasUsuario);
        return ViewBag.VBCompResp;
    }
}
