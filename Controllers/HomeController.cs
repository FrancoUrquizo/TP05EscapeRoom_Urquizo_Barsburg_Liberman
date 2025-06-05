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

 public IActionResult InicializarJuego ()
    {
        JuegoEscape InicializarJuego = new JuegoEscape ();
      string json = Objeto.ObjectToString(InicializarJuego);
       HttpContext.Session.SetString("Juego", json);
    
        return View("Index");
    }

    public IActionResult CompararRespuesta (string RespuestasUsuario)
    {
        JuegoEscape InicializarJuego = Objeto.StringToObject<JuegoEscape>(HttpContext.Session.GetString("Juego")); 
        ViewBag.VBCompResp = InicializarJuego.compararRespuesta(RespuestasUsuario);
    
        return View(" ");
    }
    public IActionResult DevolverPista (int Sala)
    {
    JuegoEscape InicializarJuego = Objeto.StringToObject<JuegoEscape>(HttpContext.Session.GetString("Juego")); 
    ViewBag.DevPista = InicializarJuego.devolverPista(Sala);
    return View(" ");
    }


}
