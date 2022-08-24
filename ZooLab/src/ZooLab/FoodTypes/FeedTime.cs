using System;
using ZooLab.Employees;

namespace ZooLab.FoodTypes
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