using ListadoPersonasCA.Domain.Entities;
using ListadoPersonasCA.Domain.Repositories;
using System.Collections.Generic;

namespace ListadoPersonasCA.Data.Repositories
{
    public class PersonaRepository100 : IPersonaRepository
    {
        public List<Persona> GetListaPersonas()
        {
            var lista = new List<Persona>();
            for (int i = 1; i <= 100; i++)
            {
                lista.Add(new Persona(i, $"Persona{i}", $"Apellido{i}", DateTime.Now.AddYears(-20 - i)));
            }
            return lista;
        }
    }
}
