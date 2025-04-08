namespace Decorator.Characters
{
    public abstract class Hero
    {
        public virtual int Health { get; set; }
        public virtual int Mana { get; set; }
        public virtual int Strength { get; set; }
        abstract public double GetRatingPvP();
        public void GetStats()
        {
            Console.WriteLine($"┌─ Strength  {Strength}");
            Console.WriteLine($"├─ Health    {Health}");
            Console.WriteLine($"└─ Mana      {Mana}");
        }
    }
}
