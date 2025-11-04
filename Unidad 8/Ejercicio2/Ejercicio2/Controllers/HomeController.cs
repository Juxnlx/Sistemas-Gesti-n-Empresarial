using Microsoft.AspNetCore.Mvc;

namespace MVC_Ejercicio2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string nombre)
        {
            ViewBag.Nombre = nombre;
            return View("Saludo");
        }

        public ActionResult Saludo()
        {
            return View();
        }
    }
}
