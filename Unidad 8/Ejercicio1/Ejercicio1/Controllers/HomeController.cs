using Microsoft.AspNetCore.Mvc;

namespace TuProyecto.Controllers
{
    public class HomeController : Controller
    {
        // Acción principal: muestra la página inicial
        public ActionResult Index()
        {
            return View();
        }

        // Acción Saludo: recibe el nombre por query string
        public ActionResult Saludo(string nombre)
        {
            ViewBag.Nombre = nombre;
            return View();
        }
    }
}


