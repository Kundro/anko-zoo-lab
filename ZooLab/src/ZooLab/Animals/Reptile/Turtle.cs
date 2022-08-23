using System.Linq;

namespace ZooLab.Animals.Reptile
{
    public class Turtle : Reptile
    {
        public override int RequiredSpaceSqFt => 5;
        public override string[] FavoriteFood => new string[] { "Grass" };
        public static readonly string[] Friends = new string[]
        {
            "Snake",
            "Parrot",
            "Bison",
            "Elephant",
            "Turtle"
        };
        public override bool IsFriendlyWith(Animal animal)
        {
            return Friends.Contains(animal.GetType().Name);
        }
    }
}
