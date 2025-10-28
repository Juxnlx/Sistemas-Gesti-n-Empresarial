using ListadoPersonasClean.Domain.Entities;
using ListadoPersonasClean.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace ListadoPersonasClean.Infrastructure.Repositories
{
    public class InMemoryPersonRepository : IPersonRepository
    {
        private readonly List<Person> _people = new()
        {
            new Person(1, "Ana", "Garc�a", new DateTime(1998,5,12)),
            new Person(2, "Luis", "P�rez", new DateTime(1995,8,22)),
            new Person(3, "Marta", "L�pez", new DateTime(2000,1,30))
        };

        public List<Person> GetAllPersons() => _people;
    }
}

