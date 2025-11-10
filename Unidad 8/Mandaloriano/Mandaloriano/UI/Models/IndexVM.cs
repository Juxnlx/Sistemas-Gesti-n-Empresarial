using Mandaloriano.Domain.Entities;

namespace Mandaloriano.UI.Models
{
    public class IndexVM
    { /// <summary>
      /// Lista completa de misiones disponibles
      /// </summary>
        public List<Mision> ListadoDeMisiones { get; set; }

        /// <summary>
        /// Misión seleccionada por el usuario
        /// </summary>
        public Mision MisionSeleccionada { get; set; }

        /// <summary>
        /// Mensaje de error (por ejemplo, si es madrugada)
        /// </summary>
        public string MensajeError { get; set; }
    }
}
