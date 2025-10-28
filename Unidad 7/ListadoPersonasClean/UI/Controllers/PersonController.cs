using Microsoft.AspNetCore.Mvc;
using ListadoPersonasClean.Application.Interfaces;

namespace ListadoPersonasClean.UI.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult Index()
        {
            var people = _personService.GetAllPersons();
            return View(people);
        }
    }
}

