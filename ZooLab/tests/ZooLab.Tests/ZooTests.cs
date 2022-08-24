using System;
using Xunit;
using ZooLab.Animals.Mammal;
using ZooLab.Animals.Reptile;
using ZooLab.Employees;
using ZooLab.Exceptions;

namespace ZooLab.Tests
{
    public class ZooTests
    {
        [Fact]
        public void ShouldBeAbleToAddEnclosure()
        {
            Zoo zoo = new Zoo("Zoo1");

            const string name = "Enclosure1";
            const int squareFeet = 10000;
            var Enclosure1 = zoo.AddEnclosure(name, squareFeet, zoo);
            Assert.Equal(name, Enclosure1.Name);
        }

        [Fact]
        public void ShouldBeAbleToAddAnimal()
        {
            Zoo zoo = new Zoo("Zoo2");
            zoo.AddEnclosure("Enclosure1", 200, zoo);
            zoo.AddEnclosure("Enclosure2", 1000, zoo);
            Snake snake = new Snake();
            Lion lion1 = new Lion();

            zoo.AddAnimal(snake);
            zoo.AddAnimal(lion1);
        }

        [Fact]
        public void ShouldNotBeAbleToAddAnimal()
        {
            Zoo zoo = new Zoo("Zoo3");
            zoo.AddEnclosure("Enclosure1", 1200, zoo);
            zoo.AddEnclosure("Enclosure2", 1000, zoo);
            Snake snake = new Snake();
            Lion lion1 = new Lion();
            Lion lion2 = new Lion();

            zoo.AddAnimal(snake);
            zoo.AddAnimal(lion1);
            Assert.Throws<NoAvailableEnclosureException>(() => zoo.AddAnimal(lion2));
        }

        [Fact]
        public void ShouldBeAbleToFindAvailableEnclosure()
        {
            Zoo zoo = new Zoo("Zoo4");
            var test1 = zoo.AddEnclosure("test1", 100, zoo);
            var test2 = zoo.AddEnclosure("test2", 200, zoo);
            var test3 = zoo.AddEnclosure("test3", 300, zoo);

            Snake snake = new Snake();
            Assert.Equal(zoo.FindAvailableEnclosure(snake), test1);
            Assert.Throws<NoAvailableEnclosureException>(() => zoo.FindAvailableEnclosure(new Bison()));
        }
        [Fact]
        public void ShouldBeAbleToHireEmployee()
        {
            Zoo zoo = new Zoo("Minsk");
            zoo.AddEnclosure("enclosure1", 2000, zoo);
            Lion lion1 = new Lion();
            zoo.AddAnimal(lion1);
            Zookeeper zookeeper = new Zookeeper("Alex", "Kun");
            zookeeper.AddAnimalExperience(new Lion());
            zoo.HireEmployee(zookeeper);
        }

        [Fact]
        public void ShouldBeAbleToFeedAnimals()
        {
            Zoo zoo = new Zoo("zoo1");
            zoo.AddEnclosure("Snakes", 200, zoo);
            Snake snake = new Snake();
            zoo.FindAvailableEnclosure(snake);
            zoo.AddAnimal(snake);
            Zookeeper zookeeper1 = new Zookeeper("name1", "surname1");
            Zookeeper zookeeper2 = new Zookeeper("name2", "surname2");
            zookeeper1.AddAnimalExperience(new Bison());
            zookeeper2.AddAnimalExperience(new Snake());
            zoo.HireEmployee(zookeeper1);
            zoo.HireEmployee(zookeeper2);
            zoo.FeedAnimals(DateTime.Now);
        }

        [Fact]
        public void ShouldBeAbleToHealAnimals()
        {
            Zoo zoo = new Zoo("zoo1");
            zoo.AddEnclosure("Snakes", 200, zoo);
            Snake snake = new Snake();
            zoo.FindAvailableEnclosure(snake);
            zoo.AddAnimal(snake);
            Veterinarian veterinarian1 = new Veterinarian("name1", "surname1");
            Veterinarian veterinarian2 = new Veterinarian("name2", "surname2");
            veterinarian1.AddAnimalExperience(new Bison());
            veterinarian2.AddAnimalExperience(new Snake());
            zoo.HireEmployee(veterinarian1);
            zoo.HireEmployee(veterinarian2);
            zoo.HealAnimals();
        }
    }
}