using ZooLab.Animals;

namespace ZooLab.Employees
{
    public class Veterinarian : IEmployee
    {
        public Veterinarian(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public void AddAnimalExperience(Animal animal)
        {

        }
        public bool HasAnimalExperience(Animal animal)
        {
            return true;
        }
        public bool HealAnimal(Animal animal)
        {
            return true;
        }
    }
}