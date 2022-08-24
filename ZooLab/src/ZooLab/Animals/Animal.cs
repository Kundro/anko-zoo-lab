using System;
using System.Collections.Generic;
using ZooLab.Employees;
using ZooLab.FoodTypes;
using ZooLab.FoodTypes.Food;
using ZooLab.MedicineTypes;

namespace ZooLab.Animals
{
    public abstract class Animal
    {
        public Animal()
        {
            FeedTimes = new List<FeedTime>();
            ID = new Random().Next();
        }

        public Animal(bool isSick)
        {
            FeedTimes = new List<FeedTime>();
            ID = new Random().Next();
            IsSick = isSick;
        }

        public int ID { get; private set; }
        public bool IsSick { get; protected set; }
        public abstract int RequiredSpaceSqFt { get; }
        public abstract string[] FavoriteFood { get; }
        public List<FeedTime> FeedTimes { get; }
        public List<int> FeedSchedule { get; }
        public abstract bool IsFriendlyWith(Animal animal);
        public void Feed(Food food, Zookeeper zooKeeper)
        {
            // nothing
        }
        public void AddFeedSchedule(List<int> hours)
        {
            FeedSchedule.AddRange(hours);
        }
        public void Heal(Medicine medicine)
        {
            IsSick = false;
        }
    }
}