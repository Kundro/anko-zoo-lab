using System.Collections.Generic;
using Xunit;
using ZooLab.Entities.Animals.Bird;

namespace ZooLab.Tests.AnimalsTests
{
    public class AnimalsTests
    {
        [Fact]
        public void ShouldBeAbleToAddFeedSchedule()
        {
            Penguin penguin = new Penguin();
            List<int> schedule = new List<int>(){ 2, 3, 4 };
            penguin.AddFeedSchedule(schedule);
            Assert.Equal(schedule, penguin.FeedSchedule);
        }
    }
}
