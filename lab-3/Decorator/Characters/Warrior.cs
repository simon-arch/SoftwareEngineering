namespace Decorator.Characters
{
    public class Warrior : Hero
    {
        public Warrior() : base()
        {
            Health = 100;
            Mana = 10;
            Strength = 25;
        }

        public override double GetRatingPvP()
        {
            return (Health * 0.2) + (Mana * 0.1) + (Strength * 0.4);
        }
    }
}
