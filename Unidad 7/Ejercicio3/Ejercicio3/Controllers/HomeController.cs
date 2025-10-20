using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic; 
using Ejercicio1.Models.Entities;
using Ejercicio1.Models.DAL;

namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DateTime ahora = DateTime.Now;
            int hora = ahora.Hour;

            // 1. ViewData: Saludo según la hora actual
            string saludo;
            if (hora >= 6 && hora < 12)
            {
                saludo = "¡Buenos días!";
            }
            else if (hora >= 12 && hora < 20)
            {
                saludo = "¡Buenas tardes!";
            }
            else
            {
                saludo = "¡Buenas noches!";
            }
            ViewData["Saludo"] = saludo;

            // 2. ViewBag: Fecha actual en formato largo
            ViewBag.FechaActual = ahora.ToLongDateString();

            // 3. Modelo: Objeto clsPersona con datos personales
            clsPersona miPersona = new clsPersona(
                id: 1,
                nombre: "Juan Luis",
                edad: 20
            );

            // Se devuelve la vista y se le pasa el modelo
            return View(miPersona);
        }

        public IActionResult ListadoPersonas()
        {
            // Obtener el listado de personas desde la capa DAL simulada
            List<clsPersona> listado = clsListado.getListadoCompleto();

            // Pasar la lista de personas como modelo a la nueva vista
            return View(listado);
        }

        public IActionResult DetallePersona()
        {
            // 1. Obtener el listado de personas
            List<clsPersona> listado = clsListado.getListadoCompleto();

            // 2. Seleccionar la persona en la posición 3 (índice 3)
            // Si hay 6 personas, los índices van de 0 a 5.
            // Posición 3 (cuarta persona) -> Índice 3.
            clsPersona personaSeleccionada = listado[2];

            // 3. Pasar *un único objeto* como modelo a la nueva vista
            return View(personaSeleccionada);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}