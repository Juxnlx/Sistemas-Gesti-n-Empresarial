using Domain.Entities;
using Domain.UseCases.Interfaces;

namespace DOMAIN.UseCases
{
    public class PersonaListUseCase : IPersonaListUseCase
    {
        private readonly IPersonaRepository _peopleListRepository;

        // Inyectamos en el constructor el repositorio
        public PersonaListUseCase(IPersonaRepository peopleRepository)
        {
            _peopleListRepository = peopleRepository;
        }

        /// <summary>
        /// Función que devuelve un listado completo de personas aplicando las reglas de negocio necesarias
        /// </summary>
        /// <returns>Lista de personas</returns>
        public List<Persona> getPeopleList()
        {
            // Aquí se aplicarían las reglas de negocio necesarias
            return _peopleListRepository.getPeopleListRep();
        }
    }
}

