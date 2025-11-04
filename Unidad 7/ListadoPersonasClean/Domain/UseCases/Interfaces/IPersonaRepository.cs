using Domain.Entities;


namespace Domain.UseCases.Interfaces
{
    // Esta interfaz es la que deberá implementar el repositorio del proyecto Data
    public interface IPersonaRepository
    {
        public List<Persona> getPeopleListRep();
    }
}




