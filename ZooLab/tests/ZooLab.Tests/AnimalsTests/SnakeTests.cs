using FluentAssertions;
using Xunit;
using ZooLab.Entities.Animals.Mammal;
using ZooLab.Entities.Animals.Reptile;

namespace ZooLab.Tests.AnimalsTests
{
    public class SnakeTests
    {
        [Fact]
        public void ShouldBeAbleToCreateSnake()
        {
            Snake snake = new Snake();
            Assert.NotNull(snake);
            Assert.IsType<Snake>(snake);
            Assert.Equal(2, snake.RequiredSpaceSqFt);
            snake.FavoriteFood[0].Should().Be("Meat");
        }

        [Fact]
        public void ShouldBeAbleToCreateSickSnake()
        {
            Snake snake = new Snake(true);
            Assert.True(snake.IsSick);
        }

        [Fact]
        public void ShouldBeAbleToCreateSnakeWithFriends()
        {
            Snake snake = new Snake();
            Snake snake2 = new Snake();
            Assert.True(snake.IsFriendlyWith(snake2));
        }

        [Fact]
        public void ShouldNotBeAbleToCreateSnakeWithFriends()
        {
            Snake snake = new Snake();
            Bison bison = new Bison();
            Assert.False(snake.IsFriendlyWith(bison));
        }
    }
}
