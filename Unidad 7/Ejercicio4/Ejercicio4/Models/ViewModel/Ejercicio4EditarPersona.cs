using Ejercicio1.Models.Entities;
using Ejercicio1.Models.DAL;

namespace Ejercicio1.Models.ViewModel {

    public class Ejercicio4EditarPersona {
        
        private clsPersona _persona
        private List<clsDepartamento> _departamentos;
    }

    public clsPersona persona { 
            get { return _persona; }
            set { _persona = value; }
        }

      public List<clsDepartamento> departamentos { 
            get { return _departamentos; }
        }

        public Ejercicio4EditarPersona(int posicionPersona) {
            _persona = listadoPersona.GetPersona(posicionPersona);
            _departamentos = listadoDepartamento.GetDepartamentos();

        }

        public Ejercicio4EditarPersona() {
            Random rand = new Random();
            int posicionPersona = ramd.Next(listadoPersona.getPersona().Count);
            _persona = listadoPersona.GetPersona(posicionPersona);
            _departamentos = listadoDepartamento.GetDepartamentos();
        }
}