using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Interfaces.UseCases
{
    /// <summary>
    /// Interfaz del caso de uso de Departamento, define los métodos
    /// que la capa de UI puede usar para interactuar con la lógica de negocio.
    /// </summary>
    public interface IDepartamentoRepositoryUseCase
    {
        /// <summary>
        /// Obtiene el listado completo de departamentos.
        /// </summary>
        /// <returns>Lista de objetos Departamento</returns>
        List<Departamento> GetListaDepartamento();

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
        /// Solo se permite si no tiene personas asociadas.
        /// </summary>
        /// <param name="idDepartamento">ID del departamento a eliminar</param>
        /// <returns>Entero indicando éxito o fallo</returns>
        int EliminarDepartamento(int idDepartamento);
    }
}
