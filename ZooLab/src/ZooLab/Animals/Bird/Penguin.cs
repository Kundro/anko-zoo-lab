﻿using System.Linq;

namespace ZooLab.Animals.Bird
{
    public class Penguin : Bird
    {
        public override int RequiredSpaceSqFt => 10;

        public override string[] FavoriteFood => new string[] { "Meat" };
        public static readonly string[] Friends = new string[]
        {
            "Penguin"
        };
        public override bool IsFriendlyWith(Animal animal)
        {
            return Friends.Contains(animal.GetType().Name);
        }
    }
}
