using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<int> FeedSchedule { get; protected set; } = new List<int>();
        public abstract bool IsFriendlyWith(Animal animal);
        public void Feed(Food food, Zookeeper zooKeeper)
        {
            FeedTimes.Add(new FeedTime(DateTime.Now, zooKeeper));

            Console.Write($" {zooKeeper.FirstName} {zooKeeper.LastName}");

            if (!FavoriteFood.Contains(food.GetType().Name))
            {
                IsSick = true;
            }
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