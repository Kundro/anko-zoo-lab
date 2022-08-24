using System;
using System.Collections.Generic;
using System.Linq;
using ZooLab.Entities.Employees;
using ZooLab.Entities.FoodTypes;
using ZooLab.Entities.FoodTypes.Food;
using ZooLab.Entities.MedicineTypes;

namespace ZooLab.Entities.Animals
{
    public abstract class Animal
    {
        private readonly IConsole NewConsole = new MockConsole();
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
        public bool IsSick { get; protected set; } = (new Random().Next(0, 8) > 4);
        public abstract int RequiredSpaceSqFt { get; }
        public abstract string[] FavoriteFood { get; }
        public List<FeedTime> FeedTimes { get; }
        public List<int> FeedSchedule { get; protected set; } = new List<int>();
        public abstract bool IsFriendlyWith(Animal animal);
        public void Feed(Food food, Zookeeper zooKeeper)
        {
            FeedTimes.Add(new FeedTime(DateTime.Now, zooKeeper));

            NewConsole.Write($" {zooKeeper.FirstName} {zooKeeper.LastName}.");

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