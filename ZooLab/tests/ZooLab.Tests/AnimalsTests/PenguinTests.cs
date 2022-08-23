using FluentAssertions;
using Xunit;
using ZooLab.Animals.Bird;

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
        }
    }
}
