using System.Security.Cryptography; // Se mantiene, aunque no se usa en este contexto

namespace Ejercicio1.Models.Entities
{
    public class clsPersona
    {
        #region atributos privados
        private int _id;
        private string _nombre;
        #endregion

        // Nota: La región vacía ha sido eliminada por limpieza.

        #region getters y setters
        public int id { get { return _id; } } // 'id' es de solo lectura

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion

        #region constructores
        public clsPersona() { }

        // Constructor modificado para inicializar id y nombre con un valor predeterminado
        public clsPersona(int id, string nombre, int edad)
        {
            _id = id;
            _nombre = nombre;
        }

        // Mantengo tu constructor original si solo se necesita la ID
        public clsPersona(int id)
        {
            _id = id;
        }

        #endregion
    }
}