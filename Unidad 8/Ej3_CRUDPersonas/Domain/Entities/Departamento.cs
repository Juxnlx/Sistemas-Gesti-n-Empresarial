using System;

namespace Domain.Entities
{
    public class Departamento
    {
        #region ATRIBUTOS PRIVADOS

        private int _id;
        private string _nombre;

        #endregion

        #region CONSTRUCTORES

        public Departamento(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }

        // Constructor vacío
        public Departamento() { }

        #endregion

        #region GETTERS Y SETTERS

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        #endregion
    }
}
