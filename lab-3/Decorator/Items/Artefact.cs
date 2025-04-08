using Decorator.Characters;

namespace Decorator.Items
{
    public class Artefact : Inventory
    {
        private int power;
        public Artefact(Hero hero, int power) : base(hero)
        {
            this.power = power;
            base.Mana += power * 20;
        }

        public override double GetRatingPvP()
        {
            Console.WriteLine($"   [Artefact][{power}] + {20 * power} Mana.");
            return base.GetRatingPvP() + power * 5;
        }
    }
}