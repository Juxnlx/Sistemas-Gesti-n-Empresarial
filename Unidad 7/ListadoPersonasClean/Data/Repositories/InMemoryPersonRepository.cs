using ListadoPersonasClean.Domain.Entities;
using ListadoPersonasClean.Domain.Interfaces;
using System.Collections.Generic;

namespace ListadoPersonasClean.Infrastructure.Repositories
{
    public class InMemoryPersonRepository : IPersonRepository
    {
        private readonly List<Person> _people = new()
        {
            new Person { Id = 1, Name = "Ana", Age = 25 },
            new Person { Id = 2, Name = "Luis", Age = 30 },
            new Person { Id = 3, Name = "Marta", Age = 22 }
        };

        public IEnumerable<Person> GetAll()
        {
            return _people;
        }
    }
}
