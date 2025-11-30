using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interfaz de repositorio de Persona que será implementada por los
    /// repositorios de la carpeta DATA para que sus métodos puedan ser
    /// usados en otras capas sin depender directamente de la BBDD.
    /// </summary>
    public interface IPersonaRepository
    {
        /// <summary>
        /// Método que obtiene el listado completo de personas desde la BBDD.
        /// </summary>
        /// <returns>Lista de objetos Persona</returns>
        List<Persona> GetListaPersonas();

        /// <summary>
        /// Devuelve una persona específica que proviene de la BBDD.
        /// </summary>
        /// <param name="idPersona">ID de la persona a buscar</param>
        /// <returns>Objeto Persona encontrado</returns>
        Persona GetPersonaPorId(int idPersona);

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