namespace Decorator.Characters
{
    public class Mage : Hero
    {
        public Mage() : base()
        {
            Health = 50;
            Mana = 100;
            Strength = 15;
        }

        public override double GetRatingPvP()
        {
            return (Health * 0.3) + (Mana * 1.2) + (Strength * 0.2);
        }
    }
}