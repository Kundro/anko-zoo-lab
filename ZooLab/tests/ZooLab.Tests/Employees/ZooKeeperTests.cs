using FluentAssertions;
using Xunit;
using ZooLab.Entities.Animals.Mammal;
using ZooLab.Entities.Employees;
using ZooLab.Exceptions;

namespace ZooLab.Tests.Employees
{
    public class ZookeeperTests
    {
        [Fact]
        public void ShouldBeAbleToCreateZookeeper()
        {
            Zookeeper zookeeper = new Zookeeper("Alexey", "Kundro");
            zookeeper.Should().NotBeNull();
            zookeeper.GetType().Should().Be(typeof(Zookeeper));
            zookeeper.FirstName.Should().Be("Alexey");
            zookeeper.LastName.Should().Be("Kundro");
        }

        [Fact]
        public void ShouldBeAbleToHaveAnimalExperience()
        {
            Zookeeper zookeeper = new Zookeeper("Alexey", "Kundro");
            Lion lion1 = new Lion();
            zookeeper.AddAnimalExperience(lion1);
            zookeeper.HasAnimalExperience(lion1).Should().BeTrue();
        }


        [Fact]
        public void ShouldBeAbleToAddAnimalExperience()
        {
            Zookeeper zookeeper = new Zookeeper("Alexey", "Kundro");
            zookeeper.AddAnimalExperience(new Bison());
            zookeeper.HasAnimalExperience(new Bison()).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeAbleToFeedAnimal()
        {
            Zookeeper zookeeper = new Zookeeper("Alexey", "Kundro");
            zookeeper.AddAnimalExperience(new Bison());
            Bison bison1 = new Bison();
            Assert.True(zookeeper.FeedAnimal(bison1));
        }

        [Fact]
        public void ShouldNotBeAbleToFeedAnimal()
        {
            Zookeeper zookeeper = new Zookeeper("Alexey", "Kundro");
            zookeeper.AddAnimalExperience(new Lion());
            Bison bison1 = new Bison();
            Assert.Throws<NoNeededExperienceException>(() => zookeeper.FeedAnimal(bison1));
        }
    }
}
