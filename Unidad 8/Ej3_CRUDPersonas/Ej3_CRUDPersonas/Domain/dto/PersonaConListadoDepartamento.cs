using System.Collections.Generic;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Domain.DTO
{
    /// <summary>
    /// DTO que representa una persona junto con el listado de todos los departamentos.
    /// El listado no se rellena aquí, lo hace el caso de uso.
    /// </summary>
    public class PersonaConListadoDepartamento
    {
        /// <summary>
        /// Objeto Persona completo
        /// </summary>
        public Persona Persona { get; }

        /// <summary>
        /// Listado de todos los departamentos disponibles
        /// </summary>
        public List<Departamento> ListadoDepartamentos { get; }

        /// <summary>
        /// Constructor que recibe la persona y el listado de departamentos
        /// </summary>
        /// <param name="persona">Objeto Persona</param>
        /// <param name="listadoDepartamentos">Listado de Departamentos</param>
        public PersonaConListadoDepartamento(Persona persona, List<Departamento> listadoDepartamentos)
        {
            Persona = persona;
            ListadoDepartamentos = listadoDepartamentos;
        }
    }
}
