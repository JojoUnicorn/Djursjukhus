
namespace DjurSjukhus
{
    public class Animals
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public bool IsVaccinated { get; set; }
        public int NumberOfLegs { get; set; }


        public Animals(string name, string species, int age, bool isVaccinated, int numberOfLegs)
        {
            Species = species;
            Name = name;
            Age = age;
            IsVaccinated = isVaccinated;
            NumberOfLegs = numberOfLegs;
        }

        //Method for information about the animals
        public void Info()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Vaccinated: {IsVaccinated}");
            Console.WriteLine($"Number of Legs: {NumberOfLegs}");
        }
    }
}

