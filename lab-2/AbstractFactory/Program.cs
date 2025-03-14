using AbstractFactory.Factories;

class Program
{
    public static void Main(string[] args)
    {
        List<IAbstractFactory> factories = new List<IAbstractFactory>()
        {
            new BalaxyFactory(),
            new IProneFactory(),
            new KiaomiFactory()
        };

        foreach (var factory in factories)
        {
            Console.WriteLine($"== {factory.GetType()} ==");

            var laptop = factory.CreateLaptop();
            Console.WriteLine("   ┌─ Laptop");
            Console.WriteLine($"   │   Name: {laptop.Name}");
            Console.WriteLine($"   │   Camera: {laptop.Camera}");

            var ebook = factory.CreateEbook();
            Console.WriteLine("   ├─ Ebook");
            Console.WriteLine($"   │   Name: {ebook.Name}");
            Console.WriteLine($"   │   Matrix: {ebook.Matrix}");

            var smartphone = factory.CreateSmartphone();
            Console.WriteLine("   ├─ Smartphone");
            Console.WriteLine($"   │   Name: {smartphone.Name}");
            Console.WriteLine($"   │   SIM: {smartphone.SIM}");

            var netbook = factory.CreateNetbook();
            Console.WriteLine("   ├─ Netbook");
            Console.WriteLine($"   │   Name: {netbook.Name}");
            Console.WriteLine($"   └─  Platform: {netbook.Platform}\n");
        }
    }
}
