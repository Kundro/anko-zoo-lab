using FluentAssertions;
using Xunit;
using ZooLab.Animals.Mammal;
using ZooLab.Employees;
using ZooLab.Exceptions;

namespace ZooLab.Tests.Employees
{
    public class ZooKeeperTests
    {
        [Fact]
        public void ShouldBeAbleToCreateZookeeper()
        {
            Zookeeper zookeeper = new Zookeeper("Alexey", "Kundro");
            zookeeper.GetType().Should().Be(typeof(Zookeeper));
            zookeeper.Should().NotBeNull();
            zookeeper.FirstName.Should().Be("Alexey");
            zookeeper.LastName.Should().Be("Kundro");
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
