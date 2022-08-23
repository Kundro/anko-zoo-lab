using System;
using System.Collections.Generic;

namespace ZooLab
{
    public class ZooApp
    {
        public ZooApp()
        {
            _zoos = new List<Zoo>();
        }
        private List<Zoo> _zoos { get; }

        public void AddZoo(Zoo zoo)
        {
            Console.WriteLine($"Added new zoo in {zoo.Location}");
            _zoos.Add(zoo);
        }
    }
}
