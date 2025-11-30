using Domain.Entities;

namespace Domain.DTO
{
    /// <summary>
    /// DTO que representa una persona junto con el nombre del departamento al que pertenece.
    /// Útil para listados o detalles de persona.
    /// </summary>
    public class PersonaConNombreDepartamento
    {
        /// <summary>
        /// Objeto Persona completo
        /// </summary>
        public Persona Persona { get; }

        /// <summary>
        /// Nombre del departamento al que pertenece la persona
        /// </summary>
        public string NombreDepartamento { get; }

        /// <summary>
        /// Constructor que recibe la persona y el nombre del departamento
        /// </summary>
        /// <param name="persona">Objeto Persona</param>
        /// <param name="nombreDepartamento">Nombre del departamento</param>
        public PersonaConNombreDepartamento(Persona persona, string nombreDepartamento)
        {
            Persona = persona;
            NombreDepartamento = nombreDepartamento;
        }
    }
}
