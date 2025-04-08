using Decorator.Characters;

namespace Decorator.Items
{
    public class Armor : Inventory
    {
        private int durability;
        public Armor(Hero hero, int durability) : base(hero)
        {
            this.durability = durability;
            base.Health += 30 * durability;
            base.Strength += 10;
        }

        public override double GetRatingPvP()
        {
            Console.WriteLine($"   [ Armor  ][{durability}] ++ {30 * durability} Health and 10 Strength.");
            return base.GetRatingPvP() + 100 * durability;
        }
    }
}
