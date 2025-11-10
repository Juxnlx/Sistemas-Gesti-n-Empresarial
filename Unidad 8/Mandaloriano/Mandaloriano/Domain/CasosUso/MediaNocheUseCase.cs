using Mandaloriano.Domain.Entities;
using Mandaloriano.Domain.Interfaces;

namespace Mandaloriano.Domain.CasosUso
{
    public class MediaNocheUseCase
    {
        private readonly IRepository _repo;

        /// <summary>
        /// Constructor que recibe un repositorio de misiones.
        /// </summary>
        /// <param name="repo">Repositorio que implementa IRepository</param>
        public MediaNocheUseCase(IRepository repo)
        {
            _repo = repo;
        }

        /// <summary>
        /// Devuelve la lista de misiones si la hora es permitida.
        /// Lanza una excepción si es de medianoche a 8 a.m.
        /// </summary>
        /// <returns>Lista de misiones disponibles</returns>
        public List<Mision> GetMisiones()
        {
            int horaActual = DateTime.Now.Hour;

            if (horaActual >= 0 && horaActual < 8)
            {
                throw new Exception("Es tarde, Mando. Debes descansar y volver a intentarlo a las 8 de la mañana.");
            }

            return _repo.GetMisiones();
        }
    }
}
