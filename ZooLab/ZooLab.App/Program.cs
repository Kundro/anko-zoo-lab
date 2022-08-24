using System;
using ZooLab.Animals.Bird;
using ZooLab.Animals.Mammal;
using ZooLab.Animals.Reptile;
using ZooLab.Employees;

namespace ZooLab.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        public void Run()
        {
            ZooApp zooApp = new ZooApp();
            Zoo zoo1 = new Zoo("zoo1");
            Zoo zoo2 = new Zoo("zoo2");
            zooApp.AddZoo(zoo1);
            zooApp.AddZoo(zoo2);

            Snake snake = new Snake();
            Turtle turtle = new Turtle();
            Bison bison = new Bison();
            Lion lion = new Lion();
            Elephant elephant = new Elephant();
            Penguin penguin = new Penguin();
            Parrot parrot = new Parrot();

            zoo1.AddEnclosure("Enclosure1", 1000, zoo1);
            zoo1.FindAvailableEnclosure(turtle);
            zoo1.FindAvailableEnclosure(bison);
            zoo1.FindAvailableEnclosure(elephant);
            zoo1.FindAvailableEnclosure(parrot);

            zoo2.AddEnclosure("Enclosure2", 200, zoo2);
            zoo2.FindAvailableEnclosure(snake);
            zoo2.AddEnclosure("Enclosure3", 100, zoo2);
            zoo2.FindAvailableEnclosure(penguin);
            zoo2.AddEnclosure("Enclosure4", 1000, zoo2);
            zoo2.FindAvailableEnclosure(lion);

            Zookeeper zookeeper1 = new Zookeeper("name1", "surname1");
            Veterinarian veterinarian1 = new Veterinarian("name2", "surname2");
            Zookeeper zookeeper2 = new Zookeeper("name3", "surname3");
            Veterinarian veterinarian2 = new Veterinarian("name4", "surname4");

            zookeeper1.AddAnimalExperience(new Turtle());
            zookeeper1.AddAnimalExperience(new Bison());
            zookeeper1.AddAnimalExperience(new Elephant());
            zookeeper1.AddAnimalExperience(new Parrot());

            veterinarian1.AddAnimalExperience(new Turtle());
            veterinarian1.AddAnimalExperience(new Bison());
            veterinarian1.AddAnimalExperience(new Elephant());
            veterinarian1.AddAnimalExperience(new Parrot());

            zookeeper2.AddAnimalExperience(new Snake());
            zookeeper2.AddAnimalExperience(new Penguin());
            zookeeper2.AddAnimalExperience(new Lion());

            veterinarian2.AddAnimalExperience(new Snake());
            veterinarian2.AddAnimalExperience(new Penguin());
            veterinarian2.AddAnimalExperience(new Lion());

            zoo1.HireEmployee(zookeeper1);
            zoo1.HireEmployee(veterinarian1);

            zoo2.HireEmployee(zookeeper2);
            zoo2.HireEmployee(veterinarian2);

            zoo1.FeedAnimals(DateTime.Now);
            zoo2.FeedAnimals(DateTime.Now);
            zoo1.HealAnimals();
            zoo2.HealAnimals();
        }
    }
}
