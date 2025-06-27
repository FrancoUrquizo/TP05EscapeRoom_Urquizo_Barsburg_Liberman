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
        return View("Index");
    }


 public IActionResult InicializarJuego ()
    {
        JuegoEscape InicializarJuego = new JuegoEscape ("iara");
     
       HttpContext.Session.SetString("Juego", Objeto.ObjectToString(InicializarJuego));
   
        return View("Sala1");
    }
    public IActionResult Sala4()
    {
    return View("Sala4");
    }


    public IActionResult IrASala4ParedRota()
    {
    return View("Sala4ParedRota");
    }




    public IActionResult IrACartaSala1()
    {
        return View("CartaSala1");
    }
    public IActionResult Sala3Computadora ()
    {
        return View("Sala3Computadora");
    }
         public IActionResult irASala3Computadora ()
    {
        return View("sala4");
    }
    public IActionResult irASala4 ()
    {
        return View("Sala4");
    }
    public IActionResult IrAPuertaCodigo ()
    {
        return View("PuertaCodigo2");
    }
    public IActionResult IrASala1 ()
    {
        return View("Sala1");
    }


     public IActionResult IrASala2 ()
    {
        return View("Sala2");
    }
    public IActionResult IrASala3 ()
    {
        return View("Sala3");
    }
    public IActionResult IrACreditos()
    {
        return View("Creditos");
    }


     public IActionResult IrATutorial ()
    {
        return View("Tutorial");
    }
      public IActionResult IrAPresentacion ()
    {
        return View("Presentacion");
    }
    public IActionResult CompararRespuesta (string RespSala, bool TocoPista, bool tocoPreg)
    {
        JuegoEscape InicializarJuego = Objeto.StringToObject<JuegoEscape>(HttpContext.Session.GetString("Juego"));
        if(InicializarJuego == null )  
        {
          return View ("Index");
        }
       
        else
        {
            InicializarJuego.compararRespuesta(RespSala);
            if (TocoPista != false)
            {
                ViewBag.TocoPista = InicializarJuego.devolverPista();
            }
            if (tocoPreg != false)
            {
                ViewBag.tocoPreg = "TRUE";
            }
            HttpContext.Session.SetString("Juego", Objeto.ObjectToString(InicializarJuego));
            Console.WriteLine(InicializarJuego.Sala);
            return View("Sala" + InicializarJuego.Sala);
        }
    }
    public IActionResult DevolverPista (int Sala)
    {
    JuegoEscape InicializarJuego = Objeto.StringToObject<JuegoEscape>(HttpContext.Session.GetString("Juego"));
    ViewBag.DevPista = InicializarJuego.devolverPista();


    return View("Sala" + InicializarJuego.Sala);
    }
       [HttpGet]
public IActionResult Sala3()
{
    return View();
}


[HttpPost]
public IActionResult ValidarCodigo(string codigo)
{
    if (codigo.ToUpper() == "HELP")
    {
        return RedirectToAction("irASala4");
    }                                              
    else
    {
        ViewBag.Error = "Código incorrecto. Vuelvalo A Intentar.";
        return View("Sala3Computadora");
    }
}


}




