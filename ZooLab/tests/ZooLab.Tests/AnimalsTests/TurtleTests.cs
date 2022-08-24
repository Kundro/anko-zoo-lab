using FluentAssertions;
using System.Xml.Linq;
using Xunit;
using ZooLab.Animals.Bird;
using ZooLab.Animals.Mammal;
using ZooLab.Animals.Reptile;

namespace ZooLab.Tests.AnimalsTests
{
    public class TurtleTests
    {
        [Fact]
        public void ShouldBeAbleToCreateTurtle()
        {
            Turtle turtle = new Turtle();
            turtle.Should().NotBeNull();
            turtle.RequiredSpaceSqFt.Should().Be(5);
            turtle.GetType().Name.Should().Be("Turtle");
            turtle.FavoriteFood[0].Should().Be("Grass");
        }

        [Fact]
        public void ShouldBeAbleToCreateSickTurtle()
        {
            Turtle turtle = new Turtle(true);
            Assert.True(turtle.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateTurtleWithFriends()
        {
            Turtle turtle = new Turtle();
            Turtle turtle2 = new Turtle();
            Elephant elephant = new Elephant();
            Parrot parrot = new Parrot();
            Bison bison = new Bison();
            Assert.True(turtle.IsFriendlyWith(bison));
            Assert.True(turtle.IsFriendlyWith(parrot));
            Assert.True(turtle.IsFriendlyWith(turtle));
            Assert.True(turtle.IsFriendlyWith(turtle2));
            Assert.True(turtle.IsFriendlyWith(elephant));
        }

        [Fact]
        public void ShouldNotBeAbleToCreateTurtleWithFriends()
        {
            Turtle turtle = new Turtle();
            Lion leo = new Lion();
            Assert.False(turtle.IsFriendlyWith(leo));
        }
    }
}
