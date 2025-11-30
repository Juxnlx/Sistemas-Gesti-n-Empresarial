using Microsoft.AspNetCore.Mvc;

namespace Ej3_CRUDPersonas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
