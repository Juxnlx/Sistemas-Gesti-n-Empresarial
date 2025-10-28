using ListadoPersonasClean.Application.Interfaces;
using ListadoPersonasClean.Domain.Entities;
using ListadoPersonasClean.Domain.Interfaces;
using System.Collections.Generic;

namespace ListadoPersonasClean.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<Person> GetAllPersons()
        {
            return _personRepository.GetAllPersons();
        }
    }
}

