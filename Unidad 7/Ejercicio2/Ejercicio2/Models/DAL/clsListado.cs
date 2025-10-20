using System.Collections.Generic;
using Ejercicio1.Models.Entities;

namespace Ejercicio1.Models.DAL

{	public static class clsListado
	{
		public static List<clsPersona> getListadoCompleto()
		{
			List<clsPersona> listado = new List<clsPersona>();

			listado.Add(new clsPersona(id: 101, nombre: "Alicia", edad: 25));
			listado.Add(new clsPersona(id: 102, nombre: "Benito", edad: 45));
			listado.Add(new clsPersona(id: 103, nombre: "Carla", edad: 19));
			listado.Add(new clsPersona(id: 104, nombre: "David", edad: 32));
			listado.Add(new clsPersona(id: 105, nombre: "Elena", edad: 55));
			listado.Add(new clsPersona(id: 106, nombre: "Fran", edad: 28));

			return listado;
		}
	}
}