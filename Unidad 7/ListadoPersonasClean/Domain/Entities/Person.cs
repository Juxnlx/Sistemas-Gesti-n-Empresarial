namespace ListadoPersonasClean.Domain.Entities
{
    public class Person
    {
        // Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor por defecto
        public Person()
        {
        }

        // Constructor con par�metros
        public Person(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        // M�todos opcionales de la entidad
        public string GetInfo()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }

    }
}
