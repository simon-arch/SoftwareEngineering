using Decorator.Characters;
using Decorator.Items;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("== Paladin ==");
        Hero paladin = new Paladin();
        Console.WriteLine($" ─ Rating {paladin.GetRatingPvP()}");
        paladin.GetStats();

        Console.WriteLine("\n== Decorated Paladin ==");
        paladin = new Armor(new Armor(new Weapon(paladin, 3), 2), 5);
        Console.WriteLine($"\n ─ Rating {paladin.GetRatingPvP()}");
        paladin.GetStats();

        Console.WriteLine("\n== Mage ==");
        Hero mage = new Mage();
        Console.WriteLine($" ─ Rating {mage.GetRatingPvP()}");
        mage.GetStats();

        Console.WriteLine("\n== Decorated Mage ==");
        mage = new Armor(new Artefact(new Artefact(mage, 3), 4), 1);
        Console.WriteLine($"\n ─ Rating {mage.GetRatingPvP()}");
        mage.GetStats();

        Console.WriteLine("\n== Warrior ==");
        Hero warrior = new Mage();
        Console.WriteLine($" ─ Rating {warrior.GetRatingPvP()}");
        warrior.GetStats();

        Console.WriteLine("\n== Decorated Warrior ==");
        warrior = new Armor(new Weapon(new Armor(warrior, 2), 5), 6);
        Console.WriteLine($"\n ─ Rating {warrior.GetRatingPvP()}");
        warrior.GetStats();
    }
}