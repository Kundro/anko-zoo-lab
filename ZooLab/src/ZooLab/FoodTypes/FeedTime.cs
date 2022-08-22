using System;
using ZooLab.Employees;

namespace ZooLab.FoodTypes
{
    public class FeedTime
    {
        public DateTime GetFeedTime()
        {
            return DateTime.Now;
        }
        public ZooKeeper FeedByZooKeeper()
        {
            ZooKeeper zooKeeper = new ZooKeeper();
            return zooKeeper;
        }
    }
}