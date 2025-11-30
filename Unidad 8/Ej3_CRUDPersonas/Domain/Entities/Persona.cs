using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona
    {
        #region ATRIBUTOS PRIVADOS

        private int _id;
        private string _nombre;
        private string _apellidos;
        private int _edad;
        private DateTime _fechaNacimiento;
        private string _direccion;
        private string _telefono;

        #endregion

        public Persona(int id, string nombre, string apellidos, int edad, DateTime fechaNacimiento, string direccion, string telefono)
        {
            _id = id;
            _nombre = nombre;
            _apellidos = apellidos;
            _edad = edad;
            _fechaNacimiento = fechaNacimiento;
            _direccion = direccion;
            _telefono = telefono;
        }


        public Persona() { }

        #region GETTERS Y SETTERS

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _apellidos;
            }
            set
            {
                _apellidos = value;
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                _fechaNacimiento = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }
            set
            {
                _telefono = value;
            }
        }

        #endregion
    }
}