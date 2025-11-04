using Ejercicio3.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Ejercicio3.Controllers
{
    public class HomeController : Controller
    {
        // Página de inicio
        public ActionResult Index()
        {
            return View();
        }

        // Acción GET → envía el objeto clsPersona a la vista Editar
        [HttpGet]
        public ActionResult Editar()
        {
            clsPersona persona = new clsPersona()
            {
                IdPersona = 1,
                Nombre = "Alex",
                Apellidos = "García",
                Edad = 20,
                Ciudad = "Sevilla"
            };

            return View(persona);
        }

        // Acción POST → recibe los datos del formulario
        [HttpPost]
        public ActionResult Editar(clsPersona personaModificada)
        {
            return View("PersonaModificada", personaModificada);
        }

        public ActionResult PersonaModificada()
        {
            return View();
        }
    }
}

