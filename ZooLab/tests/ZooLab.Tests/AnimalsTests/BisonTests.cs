using FluentAssertions;
using Xunit;
using ZooLab.Animals.Mammal;
using ZooLab.FoodTypes.Food;

namespace ZooLab.Tests.AnimalsTests
{
    public class BisonTests
    {
        [Fact]
        public void ShouldBeAbleToCreateBison()
        {
            Bison bison = new Bison();
            bison.Should().NotBeNull();
            bison.RequiredSpaceSqFt.Should().Be(1000);
            bison.GetType().Name.Should().Be("Bison");
        }
    }
}
