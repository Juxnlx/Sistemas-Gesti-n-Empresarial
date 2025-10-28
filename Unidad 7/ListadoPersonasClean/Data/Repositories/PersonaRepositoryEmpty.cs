using ListadoPersonasCA.Domain.Entities;
using ListadoPersonasCA.Domain.Repositories;
using System.Collections.Generic;

namespace ListadoPersonasCA.Data.Repositories
{
    public class PersonaRepositoryEmpty : IPersonaRepository
    {
        public List<Persona> GetListaPersonas()
        {
            return new List<Persona>(); // lista vacía
        }
    }
}
