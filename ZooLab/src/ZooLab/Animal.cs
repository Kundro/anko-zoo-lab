using System.Collections.Generic;

namespace ZooLab
{
    public abstract class Animal
    {
        public int ID { get; set; }
        public abstract int RequiredSpaceSqFt { get; }
        public abstract string[] FavoriteFood { get; }
        public List<FeedTime> FeedTimes { get; }
        public List<int> FeedSchedule { get; }
        public bool IsFriendlyWith(Animal animal)
        {
            return true;
        }
        public void Feed(Food food, ZooKeeper zooKeeper)
        {

        }
        public bool IsSick()
        {
            return false;
        }
        public void AddFeedSchedule(List<int> hours)
        {

        }
        public void Heal(Medicine)
        {

        }
    }
}