namespace ListadoPersonasClean.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        // Constructor por defecto
        public Person() { }

        // Constructor con parámetros
        public Person(int id, string name, string lastName, DateTime birthDate)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public string GetFullName() => $"{Name} {LastName}";
    }
}

