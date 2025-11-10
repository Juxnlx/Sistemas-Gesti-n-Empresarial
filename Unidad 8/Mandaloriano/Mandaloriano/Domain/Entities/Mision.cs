namespace Mandaloriano.Domain.Entities
{
    public class Mision
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Recompensa { get; set; }

        public Mision() { }

        public Mision(int id, string nombre, string descripcion, double recompensa)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Recompensa = recompensa;
        }
    }
}
