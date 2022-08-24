using FluentAssertions;
using System;
using Xunit;
using ZooLab.Entities;

namespace ZooLab.Tests
{
    public class ZooAppTests
    {
        [Fact]
        public void ShouldBeAbleToCreateZooApp()
        {
            ZooApp app = new ZooApp();
            app.Should().NotBe(null);
        }
        [Fact]
        public void ShouldBeAbleToCreateZoo()
        {
            var zoo1 = new Zoo("Chicago"); 
            zoo1.Employees.Should().BeEmpty();
            zoo1.Enclosures.Should().BeEmpty();
            zoo1.Location.Should().NotBeNullOrEmpty();
        }
        [Fact]
        public void ShouldBeAbleToAddZoo()
        {
            var zoo = new Zoo("Chicago");
            var zooApp = new ZooApp();
            zooApp.AddZoo(zoo);
            zooApp.Should().NotBe(null);
        }

        [Fact]
        public void ShouldBeAbleToCreateLog()
        {
            MockConsole mockConsole = new MockConsole();
            mockConsole.WriteLine("Test");
            Logger.Log.Contains("Test");
        }
    }
}
