using ListadoPersonasClean.Domain.Entities;
using System.Collections.Generic;

namespace ListadoPersonasClean.Domain.Interfaces
{
    public interface IPersonRepository
    {
        List<Person> GetAllPersons();
    }
}

