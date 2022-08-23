using System.Collections.Generic;
using ZooLab.Animals;

namespace ZooLab
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
        public List<Animal> Animals { get; set; }
        public int SquareFeet { get; set; }
        public Zoo ParentZoo { get; set; }
        public void AddAnimals(Animal animal)
        {
            Animals.Add(animal);
        }
    }
}