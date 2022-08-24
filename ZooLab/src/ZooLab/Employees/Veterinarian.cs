using ZooLab.Animals;

namespace ZooLab.Employees
{
    public class Veterinarian : IEmployee
    {
        public Veterinarian(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AnimalExperiences = "";
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string AnimalExperiences { get; set; }

        public void AddAnimalExperience(Animal animal)
        {
            if (!HasAnimalExperience(animal))
            {
                AnimalExperiences = AnimalExperiences + animal.GetType().Name + "; ";
            }
        }
        public bool HasAnimalExperience(Animal animal)
        {
            if (AnimalExperiences.Contains(animal.GetType().Name)) return true;
            else return false;
        }
        public bool HealAnimal(Animal animal)
        {
            return true;
        }
    }
}