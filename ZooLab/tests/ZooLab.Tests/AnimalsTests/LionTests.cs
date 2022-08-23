using FluentAssertions;
using Xunit;
using ZooLab.Animals.Mammal;

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
        }
    }
}
