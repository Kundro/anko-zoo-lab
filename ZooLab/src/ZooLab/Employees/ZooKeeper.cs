using System;
using ZooLab.Animals;
using ZooLab.Exceptions;

namespace ZooLab.Employees
{
    public class Zookeeper : IEmployee
    {
        public Zookeeper(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
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
        public bool FeedAnimal(Animal animal)
        {
            if (!HasAnimalExperience(animal))
            {
                throw new NotFriendlyAnimalException();
            }
            Console.Write($"{animal.GetType().Name} was fed by {this.FirstName} {this.LastName}");

            return true;
        }
    }
}