using System.Collections.Generic;

namespace ZooLab
{
    public class Zoo
    {
        public List<Enclosure> Enclousures { get; set; }
        public List<IEmployee> Employees { get; set; }
        public List<Veterinarian> Veterinarians { get; set; }
        public void HireEmployee(IEmployee employee)
        {

        }
    }
}