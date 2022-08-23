using FluentAssertions;
using Xunit;
using ZooLab.Animals.Reptile;
using ZooLab.FoodTypes.Food;

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
        }
    }
}
