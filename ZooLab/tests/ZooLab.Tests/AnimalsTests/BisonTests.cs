using FluentAssertions;
using Xunit;
using ZooLab.Entities.Animals.Bird;
using ZooLab.Entities.Animals.Mammal;
using ZooLab.Entities.FoodTypes.Food;

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
            bison.FavoriteFood[0].Should().Be("Grass");
        }

        [Fact]
        public void ShouldBeAbleToCreateSickBison()
        {
            Bison bison = new Bison(true);
            Assert.True(bison.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateBisonWithFriends()
        {
            Bison bison = new Bison();
            Elephant elephant = new Elephant();
            Assert.True(bison.IsFriendlyWith(elephant));
        }

        [Fact]
        public void ShouldNotBeAbleToCreateBisonWithFriends()
        {
            Bison bison = new Bison();
            Elephant elephant = new Elephant();
            Lion leo = new Lion();
            Assert.True(bison.IsFriendlyWith(elephant));
            Assert.False(bison.IsFriendlyWith(leo));
        }
    }
}
