using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Persona
    {
        //Atributos privados
        private int _id;
        private string _nombre;
        private string _apellidos;
        private int _edad;
        private DateTime _fechaNacimiento;
        private string _direccion;
        private string _telefono;
        private int _departamentoId;
        private string _foto;

        //Constructor vacío (NECESARIO para MVC y ModelBinder)
        public Persona()
        {
        }

        //Constructor completo
        public Persona(
            int id,
            string nombre,
            string apellidos,
            int edad,
            DateTime fechaNacimiento,
            string direccion,
            string telefono,
            int departamentoId,
            string foto)
        {
            _id = id;
            _nombre = nombre;
            _apellidos = apellidos;
            _edad = edad;
            _fechaNacimiento = fechaNacimiento;
            _direccion = direccion;
            _telefono = telefono;
            _departamentoId = departamentoId;
            _foto = foto;
        }

        //Propiedades (GETTERS Y SETTERS)

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [Required(ErrorMessage = "Los apellidos son obligatorios")]
        [Display(Name = "Apellidos")]
        [MaxLength(100, ErrorMessage = "Los apellidos no pueden superar los 100 caracteres")]
        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        [Display(Name = "Edad")]
        [Range(0, 120, ErrorMessage = "La edad debe estar entre 0 y 120")]
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de nacimiento")]
        [DisplayFormat(
            DataFormatString = "{0:dd-MM-yyyy}",
            ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        [Display(Name = "Dirección")]
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        [Display(Name = "Teléfono")]
        [Phone(ErrorMessage = "El formato del teléfono no es correcto")]
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        [Required(ErrorMessage = "El departamento es obligatorio")]
        [Display(Name = "Departamento")]
        public int DepartamentoId
        {
            get { return _departamentoId; }
            set { _departamentoId = value; }
        }

        [Display(Name = "Foto")]
        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }
    }
}
