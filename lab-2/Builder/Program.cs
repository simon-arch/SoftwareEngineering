using Builder.Builders;
using Builder.Characters;

class Program
{
    public static void Main(string[] args)
    {
        var director = new CharacterDirector(new HeroBuilder());
        var hero = (Hero)director.BuildImportantHero();

        director.SetBuilder(new EnemyBuilder());
        var enemy = (Enemy)director.BuildImportantEnemy();

        Console.WriteLine("  == Hero ==");
        Console.WriteLine(hero.ToString());
        hero.DoRandomGoodThing();

        Console.WriteLine("\n  == Enemy ==");
        Console.WriteLine(enemy.ToString());
        enemy.DoRandomBadThing();
    }
}
