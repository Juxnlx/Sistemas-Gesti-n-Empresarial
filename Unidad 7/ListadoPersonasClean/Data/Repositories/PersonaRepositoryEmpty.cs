using Domain.Entities;
using Domain.UseCases.Interfaces;

namespace DATA.Repositories
{
    public class PeopleRepositoryEmpty : IPersonaRepository
    {
        /// <summary>
        /// Función que nos devuelve un listado vacío de personas
        /// pre: none
        /// post: el listado está vacío
        /// </summary>
        /// <returns>Listado vacío de personas</returns>
        public List<Persona> getPeopleListRep()
        {
            // Devuelve una lista vacía
            return new List<Persona>();
        }
    }
}
