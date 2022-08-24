using System;
using ZooLab.Entities.Animals;
using ZooLab.Exceptions;
using ZooLab.Entities.MedicineTypes;

namespace ZooLab.Entities.Employees
{
    public class Veterinarian : IEmployee
    {
        private readonly IConsole NewConsole = new MockConsole();

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
        public bool HealAnimal(Animal animal, Medicine medicine)
        {
            if (HasAnimalExperience(animal))
            {
                if (animal.IsSick)
                {
                    NewConsole.WriteLine($"{animal} was healed by veterinarian {this.FirstName} {this.LastName} with {medicine}.ss");
                    animal.Heal(medicine);
                    return true;
                }
                else return false;
            }
            else throw new NoNeededExperienceException();
        }
    }
}