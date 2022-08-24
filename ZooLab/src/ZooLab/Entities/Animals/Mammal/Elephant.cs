using System.Linq;

namespace ZooLab.Entities.Animals.Mammal
{
    public class Elephant : Mammal
    {
        public Elephant() : base()
        {

        }

        public Elephant(bool isSick) : base(isSick)
        {

        }
        public override int RequiredSpaceSqFt => 1000;

        public override string[] FavoriteFood => new string[] { "Vegetable", "Grass" };
        public static readonly string[] Friends = new string[]
        {
            "Bison",
            "Parrot",
            "Turtle"
        };
        public override bool IsFriendlyWith(Animal animal)
        {
            return Friends.Contains(animal.GetType().Name);
        }
    }
}
