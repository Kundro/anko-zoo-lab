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
        public Zookeeper FeedByZooKeeper()
        {
            Zookeeper zookeeper = new Zookeeper("Alexey", "Kundro");
            return zookeeper;
        }
    }
}