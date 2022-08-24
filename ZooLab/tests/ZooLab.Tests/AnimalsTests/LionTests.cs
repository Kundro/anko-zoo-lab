using FluentAssertions;
using Xunit;
using System.Xml.Linq;
using ZooLab.Entities.Animals.Bird;
using ZooLab.Entities.Animals.Mammal;
using ZooLab.Entities.Animals.Reptile;

namespace ZooLab.Tests.AnimalsTests
{
    public class LionTests
    {
        [Fact]
        public void ShouldBeAbleToCreateLion()
        {
            Lion lion = new Lion();
            lion.Should().NotBeNull();
            lion.RequiredSpaceSqFt.Should().Be(1000);
            lion.GetType().Name.Should().Be("Lion");
            lion.FavoriteFood[0].Should().Be("Meat");
        }

        [Fact]
        public void ShouldBeAbleToCreateSickLion()
        {
            Lion lion = new Lion(true);
            Assert.True(lion.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateLionWithFriends()
        {
            Lion lion = new Lion();
            Lion lion2 = new Lion();
            Assert.True(lion.IsFriendlyWith(lion2));
        }

        [Fact]
        public void ShouldNotBeAbleToCreateLionWithFriends()
        {
            Lion lion = new Lion();
            Bison bison = new Bison();
            Assert.False(lion.IsFriendlyWith(bison));
        }
    }
}
