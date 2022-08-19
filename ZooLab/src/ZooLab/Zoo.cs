using System;
using System.Collections.Generic;

namespace ZooLab
{
    public class Zoo
    {
        public List<Enclosure> Enclousures { get; set; }
        public List<IEmployee> Employees { get; set; }
        public List<Veterinarian> Veterinarians { get; set; }
        public Enclosure AddEnclosure(string name, int squareFeet)
        {
            Enclosure enclosure = new Enclosure();
            return enclosure;
        }
        public Enclosure FindAvailableEnclosure(Animal animal)
        {
            Enclosure enclosure = new Enclosure();
            return enclosure;
        }
        public void HireEmployee(IEmployee employee)
        {

        }
        public Enclosure AddAnimal(Animal animal)
        {
            Enclosure enclosure = new Enclosure();
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