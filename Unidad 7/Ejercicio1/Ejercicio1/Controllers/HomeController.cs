using Microsoft.AspNetCore.Mvc;
using System;
using Ejercicio1.Models.Entities;
using System.Data; 

namespace Ejercicio1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int hora = DataSetDateTime.Now.Hour;
            string saludo;
            clsPersona persona;

            DateTime ahora = DateTime.Now;
            int hora = ahora.Hour;

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

            ViewBag.FechaActual = ahora.ToLongDateString();

            clsPersona miPersona = new clsPersona(1, "JuanLuis", 20);

            return View(miPersona);
        }

        public IActionResult Privacy() { }
    }
}