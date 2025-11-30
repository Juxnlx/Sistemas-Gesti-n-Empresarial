using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Data.Repositories
{
    public class PersonasRepositoryAzure : IPersonaRepository
    {
        public int ActualizarPersona(int idPersona, Persona personaActualizada)
        {
            throw new NotImplementedException();
        }

        public int CrearPersona(Persona personaNueva)
        {
            throw new NotImplementedException();
        }

        public int EliminarPersona(int idPersona)
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetListaPersonas()
        {
            throw new NotImplementedException();
        }

        public Persona GetPersonaPorId(int idPersona)
        {
            throw new NotImplementedException();
        }
    }
}
