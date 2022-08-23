using System;
using System.Collections.Generic;
using ZooLab.Animals;
using ZooLab.Animals.Bird;
using ZooLab.Animals.Mammal;
using ZooLab.Animals.Reptile;
using ZooLab.Employees;
using ZooLab.Exceptions;

namespace ZooLab
{
    public class Zoo
    {
        public Zoo(string location)
        {
            Location = location;
            Enclosures = new List<Enclosure>();
            Employees = new List<IEmployee>(); 
        }
        public List<Enclosure> Enclosures { get; set; }
        public List<IEmployee> Employees { get; set; }
        public string Location { get; private set; }
        public Enclosure AddEnclosure(string name, int squareFeet, Zoo parentZoo)
        {
            Enclosure enclosure = new Enclosure(name, squareFeet, parentZoo);
            Enclosures.Add(enclosure);
            Console.WriteLine($"\"{name}\" enclosure was added to Zoo at {parentZoo.Location}");
            return enclosure;
        }
        public Enclosure AddAnimal(Animal animal)
        {
            Enclosure enclosure = FindAvailableEnclosure(animal);
            enclosure.AddAnimals(animal);
            return enclosure;
        }
        public Enclosure FindAvailableEnclosure(Animal animal)
        {
            foreach(Enclosure enclosure in this.Enclosures)
            {
                int enclosureOccupiedSpace = 0;
                foreach(Animal enclosureAnimals in enclosure.Animals)
                {
                    enclosureOccupiedSpace += enclosureAnimals.RequiredSpaceSqFt;
                }
                if (enclosureOccupiedSpace + animal.RequiredSpaceSqFt > enclosure.SquareFeet) continue;

                bool isFriendly = true;
                foreach(Animal enclosureAnimals in enclosure.Animals)
                {
                    if (!enclosureAnimals.IsFriendlyWith(animal))
                    {
                        isFriendly = false;
                        break;
                    }
                }

                if (isFriendly && (enclosureOccupiedSpace + animal.RequiredSpaceSqFt <= enclosure.SquareFeet))
                {
                    return enclosure;
                }
            }
            throw new NoAvailableEnclosure();
        }
        public void HireEmployee(IEmployee employee)
        {

        }
        public void FeedAnimals(DateTime dateTime)
        {

        }
        public void HealAnimals()
        {

        }
    }
}