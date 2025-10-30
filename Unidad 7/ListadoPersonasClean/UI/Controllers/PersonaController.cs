using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

namespace UI.Controllers
{
    public class PersonaController : Controller
    {
        private readonly ILogger<PersonaController> _logger;
        private readonly IGetListaPersonasUseCase _useCaseListaPersonas;

        public PersonaController(ILogger<PersonaController> logger, IGetListaPersonasUseCase useCaseListaPersonas)
        {
            _logger = logger;
            _useCaseListaPersonas = useCaseListaPersonas;
        }

        public IActionResult Index()
        {
            return View(_useCaseListaPersonas.getListaPersonas());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
