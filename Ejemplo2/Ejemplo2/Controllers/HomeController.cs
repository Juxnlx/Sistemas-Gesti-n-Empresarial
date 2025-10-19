using System.Diagnostics;
using Ejemplo2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ejemplo2.Controllers
{
    // El nombre del controlador es "Home" (se omite el sufijo "Controller" en la URL)
    public class HomeController : Controller
    {
        // La acción se llama "Index"
        public IActionResult Index()
        {
            // Devuelve la vista por defecto: Views/Home/Index.cshtml
            return View();
        }
    }
}
