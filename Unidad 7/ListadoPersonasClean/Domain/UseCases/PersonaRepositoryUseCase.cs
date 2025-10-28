using ListadoPersonasCA.Domain.Entities;
using ListadoPersonasCA.Domain.Interfaces;
using ListadoPersonasCA.Domain.Repositories;
using System.Collections.Generic;

namespace ListadoPersonasCA.Domain.UseCases
{
    public class PersonaRepositoryUseCase : IPersonaRepositoryUseCase
    {
        private readonly IPersonaRepository _personaRepository;

        // Inyección de dependencias del repositorio
        public PersonaRepositoryUseCase(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public List<Persona> GetListaPersonas()
        {
            return _personaRepository.GetListaPersonas();
        }
    }
}
