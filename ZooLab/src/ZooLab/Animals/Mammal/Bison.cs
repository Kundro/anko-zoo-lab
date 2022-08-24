using System.Linq;

namespace ZooLab.Animals.Mammal
{
    public class Bison : Mammal
    {
        public Bison() : base()
        {

        }
        public Bison(bool isSick) : base(isSick)
        {
        }
        public override int RequiredSpaceSqFt => 1000;

        public override string[] FavoriteFood => new string[] { "Vegetable", "Grass" };
        public static readonly string[] Friends = new string[]
        {
            "Elephant"
        };


        public override bool IsFriendlyWith(Animal animal)
        {
            return Friends.Contains(animal.GetType().Name);
        }
    }
}
