using System.Security.Cryptography;

namespace Ejercicio1.Models.Entities
{
    public class clsPersona
    {
        #region Atributos Privados
        private int _id;
        private string _nombre;
        private int _edad;
        #endregion

        #region Getters y Setters
       
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        #endregion

        #region Constructores
        public clsPersona() { }

        public clsPersona(int id, string nombre, int edad)
        {
            _id = id;
            _nombre = nombre;
            _edad = edad;
        }
        #endregion
    }
}