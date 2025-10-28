using PeopleApp.Application.Interfaces;
using PeopleApp.Domain.Entities;
using PeopleApp.Domain.Interfaces;
using System.Collections.Generic;

namespace PeopleApp.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return _personRepository.GetAll();
        }
    }
}
