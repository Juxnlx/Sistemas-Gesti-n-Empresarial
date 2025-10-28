using ListadoPersonasClean.Domain.Entities;
using System.Collections.Generic;

namespace ListadoPersonasClean.Application.Interfaces
{
    public interface IPersonService
    {
        List<Person> GetAllPersons();
    }
}

