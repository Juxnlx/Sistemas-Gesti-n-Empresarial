using Domain.Entities;


namespace Domain.UseCases.Interfaces
{
    // Esta interfaz es la que deberá implementar el caso de uso
    public interface IPersonaListUseCase
    {
        public List<Persona> getPeopleList();
    }
}


