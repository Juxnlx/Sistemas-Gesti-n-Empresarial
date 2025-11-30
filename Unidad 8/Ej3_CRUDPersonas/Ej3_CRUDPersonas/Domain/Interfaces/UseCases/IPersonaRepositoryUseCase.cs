using System.Collections.Generic;
using Domain.Entities;
using Domain.DTO;

namespace Domain.Interfaces.UseCases
{
    /// <summary>
    /// Interfaz del caso de uso de Persona, define los métodos
    /// que la capa de UI puede usar para interactuar con la lógica de negocio.
    /// </summary>
    public interface IPersonaRepositoryUseCase
    {
        /// <summary>
        /// Obtiene el listado de personas junto con el nombre del departamento al que pertenecen.
        /// </summary>
        /// <returns>Lista de PersonaConNombreDepartamento</returns>
        List<PersonaConNombreDepartamento> GetListaPersonasConNombreDepartamento();

        /// <summary>
        /// Devuelve un DTO de Persona junto con el listado de todos los departamentos.
        /// Esto permite que la UI pueda mostrar un formulario con selección de departamento.
        /// </summary>
        /// <param name="idPersona">ID de la persona a obtener</param>
        /// <returns>DTO PersonaConListadoDepartamento</returns>
        PersonaConListadoDepartamento GetPersonaConListadoDepartamento(int idPersona);

        /// <summary>
        /// Devuelve un DTO de Persona junto con el nombre del departamento al que pertenece.
        /// </summary>
        /// <param name="idPersona">ID de la persona a obtener</param>
        /// <returns>DTO PersonaConNombreDepartamento</returns>
        PersonaConNombreDepartamento GetPersonaConNombreDepartamento(int idPersona);

        /// <summary>
        /// Método que crea una nueva persona en la BBDD.
        /// </summary>
        /// <param name="personaNueva">Objeto Persona a crear</param>
        /// <returns>Entero indicando éxito o fallo</returns>
        int CrearPersona(Persona personaNueva);

        /// <summary>
        /// Método que actualiza los datos de una persona existente.
        /// </summary>
        /// <param name="idPersona">ID de la persona a actualizar</param>
        /// <param name="personaActualizada">Objeto Persona con los nuevos datos</param>
        /// <returns>Entero indicando éxito o fallo</returns>
        int ActualizarPersona(int idPersona, Persona personaActualizada);

        /// <summary>
        /// Método que elimina una persona de la BBDD.
        /// </summary>
        /// <param name="idPersona">ID de la persona a eliminar</param>
        /// <returns>Entero indicando éxito o fallo</returns>
        int EliminarPersona(int idPersona);
    }
}
