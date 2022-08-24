using System;
using System.Collections.Generic;
using ZooLab.Entities.Animals;

namespace ZooLab.Entities
{
    public class Enclosure
    {
        public Enclosure(string name, int squareFeet, Zoo parentZoo)
        {
            Name = name;
            SquareFeet = squareFeet;
            ParentZoo = parentZoo;
        }
        public string Name { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public int SquareFeet { get; set; }
        public Zoo ParentZoo { get; set; }
        public void AddAnimals(Animal animal)
        {
            Console.WriteLine($"{animal.GetType().Name} was added to enclosure {Name}");
            Animals.Add(animal);
        }
    }
}