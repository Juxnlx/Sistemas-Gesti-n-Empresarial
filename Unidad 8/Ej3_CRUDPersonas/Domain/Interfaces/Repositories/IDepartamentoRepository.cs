using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interfaz de repositorio de Departamento que será implementada por los
    /// repositorios de la carpeta DATA para que sus métodos puedan ser
    /// usados en otras capas sin depender directamente de la BBDD.
    /// </summary>
    public interface IDepartamentoRepository
    {
        /// <summary>
        /// Método que obtiene el listado completo de departamentos desde la BBDD.
        /// </summary>
        /// <returns>Lista de objetos Departamento</returns>
        List<Departamento> GetListaDepartamentos();

        /// <summary>
        /// Devuelve un departamento específico que proviene de la BBDD.
        /// </summary>
        /// <param name="idDepartamento">ID del departamento a buscar</param>
        /// <returns>Objeto Departamento encontrado</returns>
        Departamento GetDepartamentoPorId(int idDepartamento);

        /// <summary>
        /// Método que crea un nuevo departamento en la BBDD.
        /// </summary>
        /// <param name="departamentoNuevo">Objeto Departamento a crear</param>
        /// <returns>Entero indicando éxito o fallo</returns>
        int CrearDepartamento(Departamento departamentoNuevo);

        /// <summary>
        /// Método que actualiza los datos de un departamento existente.
        /// </summary>
        /// <param name="idDepartamento">ID del departamento a actualizar</param>
        /// <param name="departamentoActualizado">Objeto Departamento con los nuevos datos</param>
        /// <returns>Entero indicando éxito o fallo</returns>
        int ActualizarDepartamento(int idDepartamento, Departamento departamentoActualizado);

        /// <summary>
        /// Método que elimina un departamento de la BBDD.
        /// </summary>
        /// <param name="idDepartamento">ID del departamento a eliminar</param>
        /// <returns>Entero indicando éxito o fallo</returns>
        int EliminarDepartamento(int idDepartamento);

        /// <summary>
        /// Método que cuenta cuántas personas pertenecen a un departamento específico.
        /// Esto es útil para validar la regla de negocio que impide borrar
        /// un departamento con personas asignadas.
        /// </summary>
        /// <param name="idDepartamento">ID del departamento</param>
        /// <returns>Número de personas asociadas al departamento</returns>
        int ContarPersonasDepartamento(int idDepartamento);
    }
}
