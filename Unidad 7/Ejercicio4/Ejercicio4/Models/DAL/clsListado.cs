using System.Collections.Generic;
using Ejercicio1.Models.Entities;

namespace Ejercicio4.Models.DAL
{
    public static class clsListado
    {
        public static List<clsPersona> getListadoCompleto()
        {
            List<clsPersona> listado = new List<clsPersona>();

            listado.Add(new clsPersona(id: 101, nombre: "Alicia", edad: 25, idDepartamento: 1));
            listado.Add(new clsPersona(id: 102, nombre: "Benito", edad: 45, idDepartamento: 2));
            listado.Add(new clsPersona(id: 103, nombre: "Carla", edad: 19, idDepartamento: 1));
            listado.Add(new clsPersona(id: 104, nombre: "David", edad: 32, idDepartamento: 3));
            listado.Add(new clsPersona(id: 105, nombre: "Elena", edad: 55, idDepartamento: 2));
            listado.Add(new clsPersona(id: 106, nombre: "Fran", edad: 28, idDepartamento: 3));

            return listado;
        }

        public static List<clsDepartamento> getListadoDepartamentos()
        {
            return new List<clsDepartamento>
            {
                new clsDepartamento(1, "Administración"),
                new clsDepartamento(2, "Desarrollo"),
                new clsDepartamento(3, "Marketing"),
                new clsDepartamento(4, "Recursos Humanos")
            };
        }
    }
}