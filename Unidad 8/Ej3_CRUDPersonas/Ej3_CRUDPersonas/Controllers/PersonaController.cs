using Domain.Entities;
using Domain.UseCases;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ej3_CRUDPersonas.Controllers
{
    /// <summary>
    /// Controller que gestiona todas las operaciones relacionadas con las Personas
    /// </summary>
    public class PersonaController : Controller
    {
        // Inyección del UseCase de Persona
        private readonly IPersonaRepositoryUseCase _personaUseCase;

        /// <summary>
        /// Constructor que recibe el UseCase mediante inyección de dependencias
        /// </summary>
        /// <param name="personaUseCase"></param>
        public PersonaController(IPersonaRepositoryUseCase personaUseCase)
        {
            _personaUseCase = personaUseCase;
        }

        /// <summary>
        /// Muestra el listado de personas con nombre del departamento
        /// </summary>
        /// <returns>Vista Mostrar.cshtml</returns>
        public IActionResult Mostrar()
        {
            List<PersonaConNombreDepartamento> listadoPersonas = _personaUseCase.getListaPersonasConNombreDepartamento();
            return View(listadoPersonas);
        }

        /// <summary>
        /// GET: Crea una nueva persona
        /// Devuelve la vista Crear.cshtml con listado de departamentos
        /// </summary>
        /// <returns>Vista Crear</returns>
        public IActionResult Crear()
        {
            List<Departamento> listadoDepartamentos = _personaUseCase.getPersonaConListadoDepartamento().listadoDepartamento;
            ViewBag.ListadoDepartamentos = new SelectList(listadoDepartamentos, "ID", "nombre");
            return View();
        }

        /// <summary>
        /// POST: Crea una nueva persona en la BBDD
        /// </summary>
        /// <param name="personaNueva"></param>
        /// <returns>Redirige a Mostrar si se crea correctamente</returns>
        [HttpPost]
        public IActionResult Crear(Persona personaNueva)
        {
            if (ModelState.IsValid)
            {
                _personaUseCase.crearPersona(personaNueva);
                return RedirectToAction("Mostrar");
            }
            return View(personaNueva);
        }

        /// <summary>
        /// GET: Edita una persona
        /// </summary>
        /// <param name="idPersona"></param>
        /// <returns>Vista Editar.cshtml con la persona y listado de departamentos</returns>
        public IActionResult Editar(int idPersona)
        {
            Persona persona = _personaUseCase.getPersonaConNombreDepartamento().persona;
            List<Departamento> listadoDepartamentos = _personaUseCase.getPersonaConListadoDepartamento().listadoDepartamento;

            var personaConListado = new PersonaConListadoDepartamento(persona)
            {
                listadoDepartamento = listadoDepartamentos
            };

            return View(personaConListado);
        }

        /// <summary>
        /// POST: Actualiza los datos de una persona
        /// </summary>
        /// <param name="idPersona"></param>
        /// <param name="personaActualizada"></param>
        /// <returns>Redirige a Mostrar</returns>
        [HttpPost]
        public IActionResult Editar(int idPersona, Persona personaActualizada)
        {
            if (ModelState.IsValid)
            {
                _personaUseCase.actualizarPersona(idPersona, personaActualizada);
                return RedirectToAction("Mostrar");
            }
            return View(personaActualizada);
        }

        /// <summary>
        /// GET: Elimina una persona (pregunta de confirmación)
        /// </summary>
        /// <param name="idPersona"></param>
        /// <returns>Vista Eliminar.cshtml</returns>
        public IActionResult Eliminar(int idPersona)
        {
            Persona persona = _personaUseCase.getPersonaConNombreDepartamento().persona;
            return View(persona);
        }

        /// <summary>
        /// POST: Elimina la persona seleccionada
        /// </summary>
        /// <param name="idPersona"></param>
        /// <returns>Redirige a Mostrar</returns>
        [HttpPost, ActionName("Eliminar")]
        public IActionResult EliminarPost(int idPersona)
        {
            _personaUseCase.eliminarPersona(idPersona);
            return RedirectToAction("Mostrar");
        }

        /// <summary>
        /// Muestra los detalles de una persona
        /// </summary>
        /// <param name="idPersona"></param>
        /// <returns>Vista Details.cshtml</returns>
        public IActionResult Details(int idPersona)
        {
            PersonaConNombreDepartamento personaDetalle = _personaUseCase.getPersonaConNombreDepartamento();
            return View(personaDetalle);
        }
    }
}