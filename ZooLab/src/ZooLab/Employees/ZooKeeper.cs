﻿using System;
using ZooLab.Animals;
using ZooLab.Exceptions;
using ZooLab.FoodTypes.Food;

namespace ZooLab.Employees
{
    public class Zookeeper : IEmployee
    {
        public Zookeeper(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AnimalExperiences = "";
        }
        public string FirstName { get; private set; }

        public string LastName { get; private set; }
        public string AnimalExperiences { get; private set; }
        public void AddAnimalExperience(Animal animal)
        {
            if (!HasAnimalExperience(animal))
            {
                AnimalExperiences = AnimalExperiences + animal.GetType().Name + "; ";
            }
        }
        public bool HasAnimalExperience(Animal animal)
        {
            if (AnimalExperiences.Contains(animal.GetType().Name)) return true;
            else return false;
        }
        public bool FeedAnimal(Animal animal)
        {
            if (!HasAnimalExperience(animal))
            {
                throw new NoNeededExperienceException();
            }
            Console.Write($"... {animal.GetType().Name} was fed by {FirstName} {LastName}");
            Food food = new Meat();
            animal.Feed(food, this);
            animal.FeedTimes.Add(new FoodTypes.FeedTime(DateTime.Now, this));
            return true;
        }
    }
}