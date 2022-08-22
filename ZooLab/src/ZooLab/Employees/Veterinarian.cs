using ZooLab.Animals;

namespace ZooLab.Employees
{
    public class Veterinarian
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
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