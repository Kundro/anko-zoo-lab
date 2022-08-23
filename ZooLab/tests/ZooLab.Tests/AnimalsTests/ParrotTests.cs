using FluentAssertions;
using Xunit;
using ZooLab.Animals.Bird;

namespace ZooLab.Tests.AnimalsTests
{
    public class ParrotTests
    {
        [Fact]
        public void ShouldBeAbleToCreateParrot()
        {
            Parrot parrot = new Parrot();
            parrot.Should().NotBeNull();
            parrot.RequiredSpaceSqFt.Should().Be(5);
            parrot.GetType().Name.Should().Be("Parrot");
        }
    }
}
