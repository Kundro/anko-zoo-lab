using System.Linq;

namespace ZooLab.Entities.Animals.Reptile
{
    public class Snake : Reptile
    {
        public Snake() : base()
        {

        }

        public Snake(bool isSick) : base(isSick)
        {

        }
        public override int RequiredSpaceSqFt => 2;
        public override string[] FavoriteFood => new string[] { "Meat" };
        public static readonly string[] Friends = new string[]
        {
            "Snake"
        };
        public override bool IsFriendlyWith(Animal animal)
        {
            return Friends.Contains(animal.GetType().Name);
        }
    }
}
