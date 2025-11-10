using Mandaloriano.Domain.Entities;

namespace Mandaloriano.Domain.Interfaces
{
    public interface ICasoUso
    {
        /// <summary>
        /// Devuelve la lista de misiones disponibles respetando la lógica de negocio.
        /// </summary>
        /// <returns>Lista de objetos Mision.</returns>
        List<Mision> GetMisiones();
    }
}
