using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Departamento
    {
        //Atributos privados
        private int _id;
        private string _nombre;

        //Constructor vacío
        public Departamento()
        {
        }

        //Constructor completo
        public Departamento(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }

        //Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required(ErrorMessage = "El nombre del departamento es obligatorio")]
        [Display(Name = "Nombre del departamento")]
        [MaxLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres")]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
