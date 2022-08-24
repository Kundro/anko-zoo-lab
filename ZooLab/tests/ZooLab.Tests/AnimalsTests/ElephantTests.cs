using FluentAssertions;
using Xunit;
using ZooLab.Entities.Animals.Bird;
using ZooLab.Entities.Animals.Mammal;
using ZooLab.Entities.Animals.Reptile;

namespace ZooLab.Tests.AnimalsTests
{
    public class ElephantTests
    {
        [Fact]
        public void ShouldBeAbleToCreateElephant()
        {
            Elephant elephant = new Elephant();
            elephant.Should().NotBeNull();
            elephant.RequiredSpaceSqFt.Should().Be(1000);
            elephant.GetType().Name.Should().Be("Elephant");
            elephant.FavoriteFood[0].Should().Be("Vegetable");
        }

        [Fact]
        public void ShouldBeAbleToCreateSickElephant()
        {
            Elephant elephant = new Elephant(true);
            Assert.True(elephant.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateElephantWithFriends()
        {
            Elephant elephant = new Elephant();
            Parrot parrot = new Parrot();
            Bison bison = new Bison();
            Turtle turtle = new Turtle();
            Assert.True(elephant.IsFriendlyWith(bison));
            Assert.True(elephant.IsFriendlyWith(parrot));
            Assert.True(elephant.IsFriendlyWith(turtle));
        }

        [Fact]
        public void ShouldNotBeAbleToCreateElephantWithFriends()
        {
            Elephant elephant = new Elephant();
            Bison bison = new Bison();
            Lion leo = new Lion();
            Assert.True(elephant.IsFriendlyWith(bison));
            Assert.False(elephant.IsFriendlyWith(leo));
        }
    }
}
