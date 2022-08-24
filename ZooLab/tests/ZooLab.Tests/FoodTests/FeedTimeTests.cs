using FluentAssertions;
using System;
using System.Linq;
using Xunit;
using ZooLab.Entities.Animals.Bird;
using ZooLab.Entities.Employees;
using ZooLab.Entities.FoodTypes;
using ZooLab.Entities.FoodTypes.Food;

namespace ZooLab.Tests.FoodTests
{
    public class FeedTimeTests
    {
        [Fact]
        public void ShouldBeAbleToCreateFeedTime()
        {
            DateTime now = DateTime.Now;
            Zookeeper employee = new Zookeeper("name", "surname");
            FeedTime feedTime = new FeedTime(now, employee);
            feedTime.Should().NotBeNull();
            now.Should().Be(feedTime.Time);
            feedTime.FeedByZooKeeper.Should().Be(employee);
        }

        [Fact]
        public void ShouldBeAbleToCreateFeed()
        {
            DateTime now = DateTime.Now;
            Zookeeper employee = new Zookeeper("name", "surname");
            Penguin penguine = new Penguin();
            Food penguinFood = new Meat();
            penguine.Feed(penguinFood, employee);
        }

        [Fact]
        public void ShouldNotBeAbleToCreateFeed()
        {
            DateTime now = DateTime.Now;
            Zookeeper employee = new Zookeeper("name", "surname");
            Penguin penguin = new Penguin();
            Food penguinFood = new Grass();
            penguin.Feed(penguinFood, employee);
            Assert.False(penguin.FavoriteFood.Contains(penguinFood.GetType().Name));

        }
    }
}
