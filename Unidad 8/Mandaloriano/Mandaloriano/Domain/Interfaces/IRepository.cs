using Mandaloriano.Domain.Entities;

namespace Mandaloriano.Domain.Interfaces
{
    public interface IRepository
    {
        /// <summary>
        /// Devuelve la lista completa de misiones disponibles.
        /// </summary>
        /// <returns>Lista de objetos Mision.</returns>
        List<Mision> GetMisiones();
    }
}
