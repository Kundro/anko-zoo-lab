using FluentAssertions;
using Xunit;
using ZooLab.Entities.Animals.Bird;
using ZooLab.Entities.Animals.Mammal;
using ZooLab.Entities.Animals.Reptile;

namespace ZooLab.Tests.AnimalsTests
{
    public class PenguinTests
    {
        [Fact]
        public void ShouldBeAbleToCreatePenguin()
        {
            Penguin penguin = new Penguin();
            penguin.Should().NotBeNull();
            penguin.RequiredSpaceSqFt.Should().Be(10);
            penguin.GetType().Name.Should().Be("Penguin");
            penguin.FavoriteFood[0].Should().Be("Meat");
        }

        [Fact]
        public void ShouldBeAbleToCreateSickPenguin()
        {
            Penguin penguin = new Penguin(true);
            Assert.True(penguin.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreatePenguinWithFriends()
        {
            Penguin penguin = new Penguin();
            Penguin penguin2 = new Penguin();
            Assert.True(penguin.IsFriendlyWith(penguin2));
        }

        [Fact]
        public void ShouldNotBeAbleToCreatePenguinWithFriends()
        {
            Penguin penguin = new Penguin();
            Penguin penguin2 = new Penguin();
            Lion leo = new Lion();
            Assert.True(penguin.IsFriendlyWith(penguin2));
            Assert.False(penguin.IsFriendlyWith(leo));
        }
    }
}
