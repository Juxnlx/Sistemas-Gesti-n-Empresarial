namespace ListadoPersonasCA.Domain.Entities
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona() { }

        public Persona(int id, string nombre, string apellidos, DateTime fechaNacimiento)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
        }

        public int Edad => DateTime.Now.Year - FechaNacimiento.Year -
            (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear ? 1 : 0);
    }
}
