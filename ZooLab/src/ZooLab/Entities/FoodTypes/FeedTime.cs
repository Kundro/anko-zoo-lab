using System;
using ZooLab.Entities.Employees;

namespace ZooLab.Entities.FoodTypes
{
    public class FeedTime
    {
        public FeedTime(DateTime time, Zookeeper feedByZooKeeper)
        {
            Time = time;
            FeedByZooKeeper = feedByZooKeeper;
        }

        public DateTime Time { get; set; }
        public Zookeeper FeedByZooKeeper { get; set; }
    }
}