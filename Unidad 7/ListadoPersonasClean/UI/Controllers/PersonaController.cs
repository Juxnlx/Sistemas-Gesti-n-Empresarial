using ListadoPersonasCA.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ListadoPersonasCA.UI.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IPersonaRepositoryUseCase _personaUseCase;

        public PersonaController(IPersonaRepositoryUseCase personaUseCase)
        {
            _personaUseCase = personaUseCase;
        }

        public IActionResult Index()
        {
            var personas = _personaUseCase.GetListaPersonas();
            return View(personas); // cuando tengas la vista lista
        }
    }
}
