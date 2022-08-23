using System;
using System.Collections.Generic;
using ZooLab.Animals;
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
        public List<Enclosure> Enclosures { get; private set; }
        public List<IEmployee> Employees { get; private set; }
        public string Location { get; private set; }
        public Enclosure AddEnclosure(string name, int squareFeet, Zoo parentZoo)
        {
            var enclosure = new Enclosure(name, squareFeet, this);
            Enclosures.Add(enclosure);
            Console.WriteLine($"\"{name}\" enclosure was added to Zoo at {parentZoo.Location}");
            return enclosure;
        }
        public Enclosure FindAvailableEnclosure(Animal animal)
        {
            foreach(Enclosure enclosure in Enclosures)
            {
                int enclosureOccupiedSpace = 0;
                foreach(Animal animals in enclosure.Animals)
                {
                    enclosureOccupiedSpace += animal.RequiredSpaceSqFt;
                }
                if (enclosureOccupiedSpace + animal.RequiredSpaceSqFt > enclosure.SquareFeet) continue;

                bool isFriendly = true;
                foreach(Animal animals in enclosure.Animals)
                {
                    if (!animals.IsFriendlyWith(animal))
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
        public Enclosure AddAnimal(Animal animal)
        {
            Enclosure enclosure = FindAvailableEnclosure(animal);
            enclosure.AddAnimals(animal);
            return enclosure;
        }
        public void FeedAnimals(DateTime dateTime)
        {

        }
        public void HealAnimals()
        {

        }
    }
}