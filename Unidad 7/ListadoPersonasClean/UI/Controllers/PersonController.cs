using Microsoft.AspNetCore.Mvc;
using ListadoPersonasClean.Application.Interfaces;
using ListadoPersonasClean.Domain.Entities;
using System.Collections.Generic;

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
            List<Person> people = _personService.GetAllPersons();
            return View(people); // Por ahora la vista se deja vacía
        }
    }
}


