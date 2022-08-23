using FluentAssertions;
using Xunit;
using ZooLab.Animals.Mammal;

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
        }
    }
}
