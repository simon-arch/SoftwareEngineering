namespace Composite.Strategy
{
    public class WebSourceStrategy : ISourceStrategy
    {
        public void Load(string source)
        {
            Console.WriteLine($"[ISourceStrategy] Image loaded from the web. | Source: {source}");
        }
    }
}
