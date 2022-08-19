using System;
using Xunit;

namespace ZooLab.Tests
{
    public class ZooAppTests
    {
        [Fact]
        public void ShouldBeAbleToCreateZooApp()
        {
            ZooApp zooApp = new ZooApp();
            Assert.NotNull(zooApp);
        }

        public void ShouldBeAbleToAddZoo()
        {
            Zoo zoo1 = new Zoo(); 
            ZooApp zooApp = new ZooApp();
            zooApp.AddZoo(zoo1);
        }
    }
}
