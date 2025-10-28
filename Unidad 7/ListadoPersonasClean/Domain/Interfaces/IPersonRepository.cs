using ListadoPersonasClean.Domain.Entities;
using System.Collections.Generic;

namespace PeopleApp.Domain.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
    }
}
