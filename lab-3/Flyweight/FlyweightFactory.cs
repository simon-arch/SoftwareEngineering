namespace Flyweight
{
    public static class FlyweightFactory
    {
        private static readonly Dictionary<string, Flyweight> cache = new Dictionary<string, Flyweight>();
        public static Flyweight GetFlyweight(string tagName, bool block, bool selfClosing)
        {
            if (!cache.TryGetValue(tagName, out var flyweight))
            {
                Console.WriteLine($"[Flyweight Factory] Cache not found. Generating for '{tagName}'.");
                flyweight = new Flyweight(tagName, block, selfClosing);
                cache[tagName] = flyweight;
            }
            return flyweight;
        }
    }
}
