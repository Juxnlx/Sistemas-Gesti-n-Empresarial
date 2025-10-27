00namespace Ejercicio1.Models.Entities
{
    public class clsDepartamento
    {
        public int idDepartamento { get; set; }
        public string nombreDepartamento { get; set; }

        public clsDepartamento(int id, string nombre)
        {
            this.idDepartamento = id;
            this.nombreDepartamento = nombre;
        }
        public clsDepartamento() { }
    }
}