using FluentAssertions;
using System.Collections.Generic;
using Xunit;
using ZooLab.Animals.Reptile;
using ZooLab.FoodTypes.Food;

namespace ZooLab.Tests
{
    public class AnimalsTests
    {
        [Fact]
        public void ShouldBeAbleToCreateSnake()
        {
            Snake snake = new Snake();
            snake.Should().NotBeNull();
            snake.RequiredSpaceSqFt.Should().Be(2);
            Assert.True(snake.FavoriteFood is Meat);
        }
    }
}
