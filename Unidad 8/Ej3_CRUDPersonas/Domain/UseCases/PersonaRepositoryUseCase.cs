using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces.UseCases;

namespace Domain.UseCases
{
    public class PersonaRepositoryUseCase : IPersonaRepositoryUseCase
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

        public List<PersonaConNombreDepartamento> GetListaPersonasConNombreDepartamento()
        {
            throw new NotImplementedException();
        }

        public PersonaConListadoDepartamento GetPersonaConListadoDepartamento(int idPersona)
        {
            throw new NotImplementedException();
        }

        public PersonaConNombreDepartamento GetPersonaConNombreDepartamento(int idPersona)
        {
            throw new NotImplementedException();
        }
    }
}