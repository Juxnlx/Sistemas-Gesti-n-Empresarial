using ListadoPersonasClean.Domain.Entities;
using System.Collections.Generic;

namespace ListadoPersonasClean.Application.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAllPersons();
    }
}
