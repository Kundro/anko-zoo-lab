namespace ZooLab
{
    public class ZooKeeper : IEmployee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string AnimalExperiences { get; set; }
        public void AddAnimalExperience(Animal animal)
        {

        }
        public bool HasAnimalExperience(Animal animal)
        {
            return false;
        }
        public bool FeedAnimal(Animal animal)
        {
            return true;
        }
    }
}