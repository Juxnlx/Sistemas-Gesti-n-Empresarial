using Mandaloriano.Data.Repositories;
using Mandaloriano.Domain.CasosUso;
using Mandaloriano.Models;
using Mandaloriano.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mandaloriano.UI.Controllers
{
    public class MisionController : Controller
    {
        private readonly MediaNocheUseCase _useCase;

        public MisionController()
        {
            // Inyección manual del repositorio al caso de uso
            _useCase = new MediaNocheUseCase(new MisionesRepository());
        }

        /// <summary>
        /// Vista principal: muestra lista de misiones o mensaje de error
        /// </summary>
        /// <returns>Vista Index</returns>
        public ActionResult Index()
        {
            var vm = new IndexVM();

            try
            {
                vm.ListadoDeMisiones = _useCase.GetMisiones();
            }
            catch (Exception ex)
            {
                vm.MensajeError = ex.Message;
                vm.ListadoDeMisiones = new System.Collections.Generic.List<Domain.Entities.Mision>();
            }

            return View(vm);
        }

        /// <summary>
        /// Acción al pulsar "Ver detalles" de una misión
        /// </summary>
        /// <param name="id">Id de la misión seleccionada</param>
        /// <returns>Vista Index con la misión seleccionada</returns>
        [HttpPost]
        public ActionResult VerDetalles(int id)
        {
            var vm = new IndexVM();

            try
            {
                var misiones = _useCase.GetMisiones();
                vm.ListadoDeMisiones = misiones;
                vm.MisionSeleccionada = misiones.FirstOrDefault(m => m.Id == id);
            }
            catch (Exception ex)
            {
                vm.MensajeError = ex.Message;
                vm.ListadoDeMisiones = new System.Collections.Generic.List<Domain.Entities.Mision>();
            }

            return View("Index", vm);
        }
    }
}
