using Microsoft.AspNetCore.Mvc;

namespace Ejemplo2.Controllers
{
    // 1. Crear un nuevo controlador llamado “ProductosController”
    public class ProductosController : Controller
    {
        // 2. Crear una acción con el nombre “ListadoProductos”
        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}