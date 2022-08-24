using FluentAssertions;
using Xunit;
using ZooLab.Entities.Animals.Bird;
using ZooLab.Entities.Employees;
using ZooLab.Entities;
using ZooLab.Validators;

namespace ZooLab.Tests.ValidatorsTests
{
    public class VeterinarianHireValidatorTests
    {
        [Fact]
        public void ShouldBeAbleToCreateValidator()
        {
            VeterinarianHireValidator validator = new VeterinarianHireValidator();
            validator.Should().NotBeNull();
        }

        [Fact]
        public void ShouldBeAbleToValidateVeterinarian()
        {
            VeterinarianHireValidator validator = new VeterinarianHireValidator();
            Zoo zoo = new Zoo("zoo1");
            zoo.AddEnclosure("enclosure1", 1000, zoo);
            Parrot parrot = new Parrot();
            zoo.AddAnimal(parrot);
            Veterinarian employee = new Veterinarian("name", "surname");
            employee.AddAnimalExperience(new Parrot());
            validator.ValidateEmployee(employee, zoo);
        }

        [Fact]
        public void ShouldNotBeAbleToValidateVeterinarian()
        {
            VeterinarianHireValidator validator = new VeterinarianHireValidator();
            Zoo zoo = new Zoo("zoo1");
            zoo.AddEnclosure("enclosure2", 1000, zoo);
            Parrot parrot = new Parrot();
            zoo.AddAnimal(parrot);
            Veterinarian employee = new Veterinarian("name", "surname");
            Assert.Equal($"Veterinarian {employee.FirstName} {employee.LastName} must have an experience to work with {parrot.GetType().Name}", validator.ValidateEmployee(employee, zoo)[0].ErrorMessage);
        }

        [Fact]
        public void ShouldNotBeAbleToValidateZookeeper()
        {
            VeterinarianHireValidator validator = new VeterinarianHireValidator();
            Zoo zoo = new Zoo("zoo1");
            zoo.AddEnclosure("enclosure2", 1000, zoo);
            Parrot parrot = new Parrot();
            zoo.AddAnimal(parrot);
            Zookeeper employee = new Zookeeper("name", "surname");
            employee.AddAnimalExperience(parrot);
            Assert.Equal($"Employee {employee.FirstName} {employee.LastName} must be a veterinarian to take VeterinarianHireValidator", validator.ValidateEmployee(employee, zoo)[0].ErrorMessage);
        }

        [Fact]
        public void ShouldBeAbleToAddAnimalExperience()
        {
            VeterinarianHireValidator validator = new VeterinarianHireValidator();
            Zoo zoo = new Zoo("zoo1");
            zoo.AddEnclosure("enclosure2", 1000, zoo);
            Parrot parrot = new Parrot();
            zoo.AddAnimal(parrot);
            Veterinarian employee = new Veterinarian("name", "surname");
            employee.AddAnimalExperience(new Parrot());
            Assert.True(employee.HasAnimalExperience(parrot));
        }
    }
}
