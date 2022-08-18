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
    }
}
