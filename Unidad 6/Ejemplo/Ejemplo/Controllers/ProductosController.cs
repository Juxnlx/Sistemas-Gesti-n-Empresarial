using Microsoft.AspNetCore.Mvc;

namespace Ejemplo.Controllers
{
    // 1. Crear un nuevo controlador llamado �ProductosController�
    public class ProductosController : Controller
    {
        // 2. Crear una acci�n con el nombre �ListadoProductos�
        public IActionResult ListadoProductos()
        {
            return View();
        }
    }
}