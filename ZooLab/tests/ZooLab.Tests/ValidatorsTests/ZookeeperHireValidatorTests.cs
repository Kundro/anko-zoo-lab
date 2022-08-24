using FluentAssertions;
using Xunit;
using ZooLab.Animals;
using ZooLab.Animals.Bird;
using ZooLab.Animals.Mammal;
using ZooLab.Employees;
using ZooLab.Exceptions;
using ZooLab.Validators;

namespace ZooLab.Tests.ValidatorsTests
{
    public class ZookeeperHireValidatorTests
    {
        [Fact]
        public void ShouldBeAbleToCreateValidator()
        {
            ZookeeperHireValidatorTests validator = new ZookeeperHireValidatorTests();
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
    }
}
