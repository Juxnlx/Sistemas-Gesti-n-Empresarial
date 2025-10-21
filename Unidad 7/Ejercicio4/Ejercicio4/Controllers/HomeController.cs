using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Ejercicio1.Models.Entities;
using Ejercicio4.Models.DAL;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ejercicio4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            DateTime ahora = DateTime.Now;
            int hora = ahora.Hour;

            // ViewData: Saludo según la hora actual
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

            // ViewBag: Fecha actual en formato largo
            ViewBag.FechaActual = ahora.ToLongDateString();

            // Modelo: Objeto clsPersona con datos personales
            // Nota: Aquí se usa el constructor de 3 argumentos, asumiendo que es el que quieres para Index.
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
            // Obtener el listado de personas
            List<clsPersona> listado = clsListado.getListadoCompleto();

            // Seleccionar la persona en la posición 3 (índice 2)
            clsPersona personaSeleccionada = listado[2];

            // Pasar *un único objeto* como modelo a la nueva vista
            return View(personaSeleccionada);
        }

        public IActionResult EditarPersona()
        {
            // Obtener una persona al azar
            List<clsPersona> listadoPersonas = clsListado.getListadoCompleto();
            Random rnd = new Random();
            int indiceAleatorio = rnd.Next(0, listadoPersonas.Count);
            clsPersona personaAEditar = listadoPersonas[indiceAleatorio];

            // Obtener el listado de departamentos
            List<clsDepartamento> listadoDepartamentos = clsListado.getListadoDepartamentos();

            // Crear el SelectList y pasarlo por ViewData
            ViewData["ListadoDepartamentos"] = new SelectList(
                listadoDepartamentos,
                "idDepartamento",        
                "nombreDepartamento",    
                personaAEditar.idDepartamento 
            );

            // Pasar la persona a editar como MODELO fuertemente tipado
            return View(personaAEditar);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}