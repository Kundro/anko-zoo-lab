using FluentAssertions;
using Xunit;
using ZooLab.Employees;

namespace ZooLab.Tests.Employees
{
    public class ZooKeeperTests
    {
        [Fact]
        public void ShouldBeAbleToCreateZooKeeper()
        {
            ZooKeeper zooKeeper = new ZooKeeper("Alexey", "Kundro");
            zooKeeper.GetType().Should().Be(typeof(ZooKeeper));
            zooKeeper.Should().NotBeNull();
            zooKeeper.FirstName.Should().Be("Alexey");
            zooKeeper.LastName.Should().Be("Kundro");
        }
        
    }
}
