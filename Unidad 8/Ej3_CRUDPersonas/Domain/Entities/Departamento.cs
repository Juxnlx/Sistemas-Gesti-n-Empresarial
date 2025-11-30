using System;

namespace Domain.Entities
{
    /// <summary>
    /// Entidad Departamento que representa los datos de la tabla Departamentos
    /// en la base de datos. Contiene todos los atributos que coinciden con
    /// las columnas definidas en SQL, así como sus constructores y propiedades.
    /// </summary>
    public class Departamento
    {
        #region ATRIBUTOS PRIVADOS

        /// <summary>
        /// Identificador único del departamento (PK en la base de datos).
        /// </summary>
        private int _id;

        /// <summary>
        /// Nombre del departamento.
        /// </summary>
        private string _nombre;

        #endregion

        #region CONSTRUCTORES

        /// <summary>
        /// Constructor con todos los atributos del departamento.
        /// </summary>
        /// <param name="id">ID del departamento</param>
        /// <param name="nombre">Nombre del departamento</param>
        public Departamento(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }

        /// <summary>
        /// Constructor vacío para poder crear objetos Departamento sin inicializar
        /// los valores desde el principio.
        /// </summary>
        public Departamento() { }

        #endregion

        #region GETTERS Y SETTERS

        /// <summary>
        /// Propiedad pública del campo ID.
        /// </summary>
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Propiedad pública del campo Nombre.
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        #endregion
    }
}
