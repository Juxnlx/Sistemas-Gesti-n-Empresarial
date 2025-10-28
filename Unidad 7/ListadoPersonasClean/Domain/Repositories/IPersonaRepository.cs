using ListadoPersonasCA.Domain.Entities;
using System.Collections.Generic;

namespace ListadoPersonasCA.Domain.Repositories
{
    public interface IPersonaRepository
    {
        List<Persona> GetListaPersonas();
    }
}
