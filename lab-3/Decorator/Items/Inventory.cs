using Decorator.Characters;

namespace Decorator.Items
{
    public abstract class Inventory : Hero
    {
        private Hero hero;
        public override int Health
        {
            get { return hero.Health; }
            set { hero.Health = value; }
        }
        public override int Strength
        {
            get { return hero.Strength; }
            set { hero.Strength = value; }
        }
        public override int Mana
        {
            get { return hero.Mana; }
            set { hero.Mana = value; }
        }
        public Inventory(Hero hero) : base()
        {
            this.hero = hero;
        }

        public override double GetRatingPvP()
        {
            return hero.GetRatingPvP();
        }
    }
}
