using System.Collections.Generic;

namespace ZooLab
{
    public class ZooApp
    {
        private List<Zoo> _zoos { get; }
        public ZooApp()
        {
            _zoos = new List<Zoo>();
        }

        public void AddZoo(Zoo zoo)
        {
            _zoos.Add(zoo);
        }
    }
}
