using Domain.Entities;
using Domain.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ej3_CRUDPersonas.Controllers
{
    /// <summary>
    /// Controller que gestiona todas las operaciones relacionadas con los Departamentos
    /// </summary>
    public class DepartamentoController : Controller
    {
        // Inyección del UseCase de Departamento
        private readonly IDepartamentoRepositoryUseCase _departamentoUseCase;

        /// <summary>
        /// Constructor que recibe el UseCase mediante inyección de dependencias
        /// </summary>
        /// <param name="departamentoUseCase"></param>
        public DepartamentoController(IDepartamentoRepositoryUseCase departamentoUseCase)
        {
            _departamentoUseCase = departamentoUseCase;
        }

        /// <summary>
        /// Muestra el listado de departamentos
        /// </summary>
        /// <returns>Vista Mostrar.cshtml</returns>
        public IActionResult Mostrar()
        {
            List<Departamento> listadoDepartamentos = _departamentoUseCase.getListaDepartamento();
            return View(listadoDepartamentos);
        }

        /// <summary>
        /// GET: Crea un nuevo departamento
        /// </summary>
        /// <returns>Vista Crear.cshtml</returns>
        public IActionResult Crear()
        {
            return View();
        }

        /// <summary>
        /// POST: Crea un nuevo departamento en la BBDD
        /// </summary>
        /// <param name="departamentoNuevo"></param>
        /// <returns>Redirige a Mostrar si se crea correctamente</returns>
        [HttpPost]
        public IActionResult Crear(Departamento departamentoNuevo)
        {
            if (ModelState.IsValid)
            {
                _departamentoUseCase.crearDepartamento(departamentoNuevo);
                return RedirectToAction("Mostrar");
            }
            return View(departamentoNuevo);
        }

        /// <summary>
        /// GET: Edita un departamento
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns>Vista Editar.cshtml</returns>
        public IActionResult Editar(int idDepartamento)
        {
            Departamento departamento = _departamentoUseCase.getListaDepartamento().Find(d => d.ID == idDepartamento);
            return View(departamento);
        }

        /// <summary>
        /// POST: Actualiza los datos de un departamento
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <param name="departamentoActualizado"></param>
        /// <returns>Redirige a Mostrar</returns>
        [HttpPost]
        public IActionResult Editar(int idDepartamento, Departamento departamentoActualizado)
        {
            if (ModelState.IsValid)
            {
                _departamentoUseCase.actualizarDepartamento(idDepartamento, departamentoActualizado);
                return RedirectToAction("Mostrar");
            }
            return View(departamentoActualizado);
        }

        /// <summary>
        /// GET: Elimina un departamento (pregunta de confirmación)
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns>Vista Eliminar.cshtml</returns>
        public IActionResult Eliminar(int idDepartamento)
        {
            Departamento departamento = _departamentoUseCase.getListaDepartamento().Find(d => d.ID == idDepartamento);
            return View(departamento);
        }

        /// <summary>
        /// POST: Elimina el departamento seleccionado
        /// No se puede borrar si hay personas en él (regla de negocio)
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns>Redirige a Mostrar</returns>
        [HttpPost, ActionName("Eliminar")]
        public IActionResult EliminarPost(int idDepartamento)
        {
            _departamentoUseCase.eliminarDepartamento(idDepartamento);
            return RedirectToAction("Mostrar");
        }

        /// <summary>
        /// Muestra los detalles de un departamento
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns>Vista Details.cshtml</returns>
        public IActionResult Details(int idDepartamento)
        {
            Departamento departamentoDetalle = _departamentoUseCase.getListaDepartamento().Find(d => d.ID == idDepartamento);
            return View(departamentoDetalle);
        }
    }
}
