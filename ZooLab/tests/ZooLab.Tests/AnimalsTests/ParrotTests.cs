using FluentAssertions;
using System.Linq;
using Xunit;
using ZooLab.Animals.Bird;
using ZooLab.Animals.Mammal;
using ZooLab.Animals.Reptile;

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
            parrot.FavoriteFood[0].Should().Be("Vegetable");
        }

        [Fact]
        public void ShouldBeAbleToCreateSickParrot()
        {
            Parrot parrot = new Parrot(true);
            Assert.True(parrot.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateParrotWithFriends()
        {
            Parrot parrot = new Parrot();
            Parrot parrot2 = new Parrot();
            Bison bison = new Bison();
            Turtle turtle = new Turtle();
            Elephant elephant = new Elephant();
            Assert.True(parrot.IsFriendlyWith(parrot2));
            Assert.True(parrot.IsFriendlyWith(elephant));
            Assert.True(parrot.IsFriendlyWith(bison));
            Assert.True(parrot.IsFriendlyWith(turtle));
        }
    }
}
