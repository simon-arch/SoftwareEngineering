namespace Decorator.Characters
{
    public class Paladin : Hero
    {
        public Paladin() : base()
        {
            Health = 75;
            Mana = 50;
            Strength = 30;
        }

        public override double GetRatingPvP()
        {
            return (Health * 0.7) + (Mana * 0.3) + (Strength * 0.5);
        }
    }
}
