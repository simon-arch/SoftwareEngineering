using Decorator.Characters;

namespace Decorator.Items
{
    public class Weapon : Inventory
    {
        private int sharpness;
        public Weapon(Hero hero, int sharpness) : base(hero)
        {
            this.sharpness = sharpness;
            base.Strength += 30 * sharpness;
        }

        public override double GetRatingPvP()
        {
            Console.WriteLine($"   [ Weapon ][{sharpness}] + {30 * sharpness} Strength.");
            return base.GetRatingPvP() + 3 * sharpness;
        }
    }
}
