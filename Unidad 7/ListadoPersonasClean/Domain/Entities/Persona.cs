namespace Domain.Entities
{
    public class Persona
    {
        #region atributos privados
        private int _id;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private string _direccion;
        private string _telefono;
        #endregion

        #region propiedades públicas
        public int Id 
        { 
            get { return _id; }
            set { _id = value; }  // Añadir setter
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido  // Cambiar de "apellido" a "Apellido"
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        #endregion

        #region constructores
        public Persona() { }
        
        public Persona(int id, string nombre, string apellido, DateTime fechaNacimiento, string direccion, string telefono)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _fechaNacimiento = fechaNacimiento;
            _direccion = direccion;
            _telefono = telefono;
        }
        #endregion
    }
}
