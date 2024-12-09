namespace DjurSjukhus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<Animals> animal = new List<Animals>
                {
                    new Animals("Ponyo", "Cat", 2, true, 4),
                    new Animals("Shadow", "Dog", 4, true, 4),
                    new Animals("Jetson", "Dog", 3, false, 6),
                    new Animals("SnooFlayk", "Cat", 6, false, 2),
                    new Animals("Black Noir", "Spider", 55, true, 54),
                    new Animals("Don Julio", "Goat", 5, false, 4),
                    new Animals("Manolo", "Dog", 14, false, 4),
                    new Animals("Thing", "Cat", 12, true, 5),
                    new Animals("Exterminator", "Hamster", 5, true, 6),
                    new Animals("Pan", "Cat", 9, true, 3),
                    new Animals("Dog", "Dog", 2, true, 4)
                };

                // How many dogs

                var NumberOfDogs = animal.Count
                (a => a.Species == "Dog");
                Console.WriteLine($"How many dogs: {NumberOfDogs}");
                Console.WriteLine("---------------");
                // Oldest animal

                var oldestAnimal = animal
                    .OrderByDescending(a => a.Age)
                    .FirstOrDefault();
                Console.WriteLine($"Oldest Animal: ");
                oldestAnimal?.Info();
                Console.WriteLine("------------------");

                // Vaccinated
                var VaccinatedAnimals = animal
                    .Where(a => a.IsVaccinated).ToList();
                Console.WriteLine("Vaccinated animals: ");
                foreach (var a in VaccinatedAnimals)
                {
                    Console.WriteLine($"'{a.Name}', {a.Species}.");
                }
                Console.WriteLine("-------------------");

                // 4-legged animal that is older than 3
                var FourLegsOlderThanThree = animal
                    .Where(a => a.NumberOfLegs == 4 && a.Age > 3).ToList();
                Console.WriteLine("4-Legged animals older than 3 years old: ");
                foreach (var a in FourLegsOlderThanThree)
                {
                    Console.WriteLine($"'{a.Name}', {a.Age} Years.");
                }
                Console.WriteLine("------------------");

                //Is there an animal called "Shadow"?

                var IsShadow = animal
                    .Any(a => a.Name == "Shadow");
                Console.WriteLine($"Animal named 'Shadow': {IsShadow}.");
                Console.WriteLine("------------------");


                Console.ReadKey();
            }
        }
    }
}   