using Xunit;
using ZooLab.Animals.Reptile;

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
        }


    }
}
