using System.Linq;

namespace ZooLab.Entities.Animals.Mammal
{
    public class Lion : Mammal
    {
        public Lion() : base()
        {

        }

        public Lion(bool isSick) : base(isSick)
        {

        }
        public override int RequiredSpaceSqFt => 1000;

        public override string[] FavoriteFood => new string[] { "Meat" };
        public static readonly string[] Friends = new string[]
        {
            "Lion"
        };
        public override bool IsFriendlyWith(Animal animal)
        {
            return Friends.Contains(animal.GetType().Name);
        }
    }
}
