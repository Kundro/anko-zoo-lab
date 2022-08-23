using FluentAssertions;
using System.Collections.Generic;
using Xunit;
using ZooLab.Animals.Mammal;
using ZooLab.Animals.Reptile;
using ZooLab.Exceptions;

namespace ZooLab.Tests
{
    public class ZooTests
    {
        [Fact]
        public void ShouldBeAbleToAddEnclosure()
        {
            Zoo zoo = new Zoo("Chicago");

            const string name = "Enclosure1";
            const int squareFeet = 10000;
            var enclosure = new Enclosure(name, squareFeet, zoo);
            zoo.AddEnclosure(enclosure.Name, enclosure.SquareFeet, enclosure.ParentZoo);
            zoo.Enclosures[0].Should().Be(enclosure);
        }

        [Fact]
        public void ShouldBeAbleToAddAnimal()
        {
            Zoo zoo = new Zoo("Chicago");

            zoo.Enclosures[0].AddAnimals(new Snake());
            zoo.Enclosures[0].AddAnimals(new Turtle());
            zoo.Enclosures[0].Animals.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void ShouldBeAbleToFindAvailableEnclosure()
        {
            Zoo zoo = new Zoo("Chicago");

            zoo.Enclosures = new List<Enclosure>();
            zoo.AddEnclosure("test1", 100, zoo);
            zoo.AddEnclosure("test2", 200, zoo);
            zoo.AddEnclosure("test3", 300, zoo);
            zoo.FindAvailableEnclosure(new Snake()).Should().Be(zoo.Enclosures[0]);
            zoo.FindAvailableEnclosure(new Turtle()).Should().Be(zoo.Enclosures[1]);
            Assert.Throws<NoAvailableEnclosure>(() => zoo.FindAvailableEnclosure(new Bison()));
        }
    }
}