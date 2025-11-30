using System;

namespace Domain.Entities
{
    /// <summary>
    /// Entidad Persona que representa los datos almacenados en la tabla Persona
    /// de la base de datos. Contiene todos los atributos que coinciden con
    /// las columnas definidas en SQL, así como sus constructores y propiedades.
    /// </summary>
    public class Persona
    {
        #region ATRIBUTOS PRIVADOS

        /// <summary>
        /// Identificador único de la persona (PK en la base de datos).
        /// </summary>
        private int _id;

        /// <summary>
        /// Nombre de la persona.
        /// </summary>
        private string _nombre;

        /// <summary>
        /// Apellidos de la persona.
        /// </summary>
        private string _apellidos;

        /// <summary>
        /// Edad de la persona.
        /// </summary>
        private int _edad;

        /// <summary>
        /// Fecha de nacimiento de la persona.
        /// </summary>
        private DateTime _fechaNacimiento;

        /// <summary>
        /// Dirección de la persona.
        /// </summary>
        private string _direccion;

        /// <summary>
        /// Teléfono de contacto.
        /// </summary>
        private string _telefono;

        /// <summary>
        /// ID del departamento al que pertenece la persona (FK).
        /// </summary>
        private int _idDepartamento;

        /// <summary>
        /// Ruta de la foto de perfil de la persona.
        /// </summary>
        private string _foto;

        #endregion

        #region CONSTRUCTORES

        /// <summary>
        /// Constructor con todos los atributos de la clase Persona.
        /// Se utiliza para crear objetos completos provenientes de la BBDD.
        /// </summary>
        public Persona(
            int id,
            string nombre,
            string apellidos,
            int edad,
            DateTime fechaNacimiento,
            string direccion,
            string telefono,
            int idDepartamento,
            string foto)
        {
            _id = id;
            _nombre = nombre;
            _apellidos = apellidos;
            _edad = edad;
            _fechaNacimiento = fechaNacimiento;
            _direccion = direccion;
            _telefono = telefono;
            _idDepartamento = idDepartamento;
            _foto = foto;
        }

        /// <summary>
        /// Constructor vacío para poder crear objetos Persona sin inicializar
        /// todos los valores desde el principio.
        /// </summary>
        public Persona() { }

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

        /// <summary>
        /// Propiedad pública del campo Apellidos.
        /// </summary>
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        /// <summary>
        /// Propiedad pública del campo Edad.
        /// </summary>
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        /// <summary>
        /// Propiedad pública del campo FechaNacimiento.
        /// </summary>
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        /// <summary>
        /// Propiedad pública del campo Dirección.
        /// </summary>
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        /// <summary>
        /// Propiedad pública del campo Teléfono.
        /// </summary>
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        /// <summary>
        /// Propiedad pública del campo Foto.
        /// </summary>
        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        /// <summary>
        /// Propiedad pública del campo IDDepartamento (FK).
        /// </summary>
        public int IDDepartamento
        {
            get { return _idDepartamento; }
            set { _idDepartamento = value; }
        }

        #endregion
    }
}