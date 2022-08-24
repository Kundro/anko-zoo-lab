using FluentAssertions;
using Xunit;
using ZooLab.Entities.Animals.Bird;
using ZooLab.Entities.Employees;
using ZooLab.Entities;
using ZooLab.Validators;

namespace ZooLab.Tests.ValidatorsTests
{
    public class ZookeeperHireValidatorTests
    {
        [Fact]
        public void ShouldBeAbleToCreateValidator()
        {
            ZookeeperHireValidator validator = new ZookeeperHireValidator();
            validator.Should().NotBeNull();
        }

        [Fact]
        public void ShouldBeAbleToValidateZookeeper()
        {
            ZookeeperHireValidator validator = new ZookeeperHireValidator();
            Zoo zoo = new Zoo("zoo1");
            zoo.AddEnclosure("enclosure1", 1000, zoo);
            Parrot parrot = new Parrot();
            zoo.AddAnimal(parrot);
            Zookeeper employee = new Zookeeper("name", "surname");
            employee.AddAnimalExperience(parrot);
            validator.ValidateEmployee(employee, zoo);
        }

        [Fact]
        public void ShouldNotBeAbleToValidateZookeeper()
        {
            ZookeeperHireValidator validator = new ZookeeperHireValidator();
            Zoo zoo = new Zoo("zoo1");
            zoo.AddEnclosure("enclosure2", 1000, zoo);
            Parrot parrot = new Parrot();
            zoo.AddAnimal(parrot);
            Zookeeper employee = new Zookeeper("name", "surname");
            Assert.Equal($"Zookeeper {employee.FirstName} {employee.LastName} must have an experience to work with {parrot.GetType().Name}", validator.ValidateEmployee(employee, zoo)[0].ErrorMessage);
        }

        [Fact]
        public void ShouldNotBeAbleToValidateVeteerinarian()
        {
            ZookeeperHireValidator validator = new ZookeeperHireValidator();
            Zoo zoo = new Zoo("zoo1");
            zoo.AddEnclosure("enclosure2", 1000, zoo);
            Parrot parrot = new Parrot();
            zoo.AddAnimal(parrot);
            Veterinarian employee = new Veterinarian("name", "surname");
            Assert.Equal($"Emplooye {employee.FirstName} {employee.LastName} must be a zookeeper to take ZookeeperHireValidator", validator.ValidateEmployee(employee, zoo)[0].ErrorMessage);
        }

        [Fact]
        public void ShouldBeAbleToAddAnimalExperience()
        {
            ZookeeperHireValidator validator = new ZookeeperHireValidator();
            Zoo zoo = new Zoo("zoo1");
            zoo.AddEnclosure("enclosure2", 1000, zoo);
            Parrot parrot = new Parrot();
            zoo.AddAnimal(parrot);
            Zookeeper employee = new Zookeeper("name", "surname");
            employee.AddAnimalExperience(new Parrot());
            Assert.True(employee.HasAnimalExperience(parrot));
        }
    }
}
