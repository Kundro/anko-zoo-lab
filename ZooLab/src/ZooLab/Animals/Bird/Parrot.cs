using System.Linq;

namespace ZooLab.Animals.Bird
{
    public class Parrot : Bird
    {
        public override int RequiredSpaceSqFt => 5;

        public override string[] FavoriteFood => new string[] { "Vegetable" };
        public static readonly string[] Friends = new string[]
        {
            "Elephant",
            "Parrot",
            "Bison",
            "Turtle"
        };
        public override bool IsFriendlyWith(Animal animal)
        {
            return Friends.Contains(animal.GetType().Name);
        }
    }
}
