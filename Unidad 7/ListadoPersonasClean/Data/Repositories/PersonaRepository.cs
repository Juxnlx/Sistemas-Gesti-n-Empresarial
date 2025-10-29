using ListadoPersonasCA.Domain.Entities;
using ListadoPersonasCA.Domain.Repositories;
using System.Collections.Generic;

namespace ListadoPersonasCA.Data.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        public static List<Persona> GetListaPersonas()
        {
            return new List<Persona>
            {
                new Persona(1, "Lucía", "Gómez", new DateTime(2000, 5, 20)),
                new Persona(2, "Carlos", "Pérez", new DateTime(1998, 11, 2)),
                new Persona(3, "Ana", "Ruiz", new DateTime(2001, 4, 15))
            };
        }
    }
}
