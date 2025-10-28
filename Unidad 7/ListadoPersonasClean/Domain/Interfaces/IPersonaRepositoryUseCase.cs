using ListadoPersonasCA.Domain.Entities;
using System.Collections.Generic;

namespace ListadoPersonasCA.Domain.Interfaces
{
    public interface IPersonaRepositoryUseCase
    {
        List<Persona> GetListaPersonas();
    }
}
