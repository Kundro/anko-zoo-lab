﻿using System.Collections.Generic;
using System.Linq;
using ZooLab.FoodTypes.Food;

namespace ZooLab.Animals.Reptile
{
    public class Snake : Reptile
    {
        public override int RequiredSpaceSqFt => 2;
        public override string[] FavoriteFood => new string[] { "Meat" };
        public static readonly string[] Friends = new string[]
        {
            "Snake"
        };
        public override bool IsFriendlyWith(Animal animal)
        {
            return Friends.Contains(animal.GetType().Name);
        }
    }
}
