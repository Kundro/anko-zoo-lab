using System;
using ZooLab.Animals;
using ZooLab.Exceptions;

namespace ZooLab.Employees
{
    public class ZooKeeper : IEmployee
    {
        public ZooKeeper(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string AnimalExperiences { get; set; } = "";
        public void AddAnimalExperience(Animal animal)
        {
            if (!HasAnimalExperience(animal))
            {
                AnimalExperiences = AnimalExperiences + animal.GetType().Name + "; ";
            }
        }
        public bool HasAnimalExperience(Animal animal)
        {
            return AnimalExperiences.Contains(animal.GetType().Name);
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