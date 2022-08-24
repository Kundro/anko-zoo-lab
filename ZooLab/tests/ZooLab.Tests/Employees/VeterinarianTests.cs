using FluentAssertions;
using Xunit;
using ZooLab.Animals.Mammal;
using ZooLab.Employees;
using ZooLab.Exceptions;
using ZooLab.MedicineTypes;

namespace ZooLab.Tests.Employees
{
    public class VeterinarianTests
    {
        [Fact]
        public void ShouldBeAbleToCreateVeterinarian()
        {
            Veterinarian veterinarian = new Veterinarian("Alexey", "Kundro");
            veterinarian.Should().NotBeNull();
            veterinarian.GetType().Should().Be(typeof(Veterinarian));
            veterinarian.FirstName.Should().Be("Alexey");
            veterinarian.LastName.Should().Be("Kundro");
        }

        [Fact]
        public void ShouldBeAbleToHaveAnimalExperience()
        {
            Veterinarian veterinarian = new Veterinarian("Alexey", "Kundro");
            Lion lion1 = new Lion();
            veterinarian.AddAnimalExperience(lion1);
            veterinarian.HasAnimalExperience(lion1).Should().BeTrue();
        }


        [Fact]
        public void ShouldBeAbleToAddAnimalExperience()
        {
            Veterinarian veterinarian = new Veterinarian("Alexey", "Kundro");
            veterinarian.AddAnimalExperience(new Bison());
            veterinarian.HasAnimalExperience(new Bison()).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeAbleToHealAnimal()
        {
            Veterinarian veterinarian = new Veterinarian("Alexey", "Kundro");
            veterinarian.AddAnimalExperience(new Bison());
            Bison bison1 = new Bison(true);
            Medicine medicine = new Antibiotics();
            Assert.True(veterinarian.HealAnimal(bison1, medicine));
        }

        [Fact]
        public void ShouldNotBeAbleToHealAnimal()
        {
            Veterinarian veterinarian = new Veterinarian("Alexey", "Kundro");
            veterinarian.AddAnimalExperience(new Lion());
            Bison bison1 = new Bison();
            Medicine medicine = new Antibiotics();
            Assert.Throws<NoNeededExperienceException>(() => veterinarian.HealAnimal(bison1, medicine));
        }

        [Fact]
        public void ShouldNotBeAbleToHealAnimalWhenAnimalIsHealthy()
        {
            Veterinarian veterinarian = new Veterinarian("Alexey", "Kundro");
            veterinarian.AddAnimalExperience(new Bison());
            Bison bison1 = new Bison(false);
            Medicine medicine = new Antibiotics();
            Assert.False(veterinarian.HealAnimal(bison1, medicine));
        }
    }
}
