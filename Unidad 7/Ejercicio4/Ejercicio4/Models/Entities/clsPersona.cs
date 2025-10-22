using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio1.Models.Entities
{
    public class clsPersona
    {
        #region Atributos Privados
        private int _id;
        private string _nombre;
        private int _edad;
        private int _idDepartamento;
        #endregion

        #region Getters y Setters
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [Range(18, 100, ErrorMessage = "La edad debe estar entre 18 y 100")]
        public int edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        [Display(Name = "Departamento")]
        public int idDepartamento
        {
            get { return _idDepartamento; }
            set { _idDepartamento = value; }
        }
        #endregion

        #region Constructores
        public clsPersona() { }


        // Constructor para edición (4 argumentos)
        public clsPersona(int id, string nombre, int edad, int idDepartamento)
        {
            _id = id;
            _nombre = nombre;
            _edad = edad;
            _idDepartamento = idDepartamento;
        }

        // Constructor original de la clase (3 argumentos)
        public clsPersona(int id, string nombre, int edad)
        {
            _id = id;
            _nombre = nombre;
            _edad = edad;
        }

        // Constructor para edición (4 argumentos)
        public clsPersona(int id, string nombre, int edad, int idDepartamento)
        {
            this._id = 0;
            this._nombre = "";
            this._edad = 0;
            this._idDepartamento = 0;
        }
        #endregion
    }
}