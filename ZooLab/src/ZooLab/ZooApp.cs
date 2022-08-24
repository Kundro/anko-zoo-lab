using System;
using System.Collections.Generic;
using ZooLab.Entities;

namespace ZooLab
{
    public class ZooApp
    {
        public IConsole NewConsole { get; set; } = new MockConsole();
        public ZooApp()
        {
            _zoos = new List<Zoo>();
        }
        private List<Zoo> _zoos { get; }

        public void AddZoo(Zoo zoo)
        {
            NewConsole.WriteLine("Added new zoo.");
            _zoos.Add(zoo);
        }
    }
}
