namespace Composite.Strategy
{
    public class FileSourceStrategy : ISourceStrategy
    {
        public void Load(string source)
        {
            Console.WriteLine($"[ISourceStrategy] Image loaded from the file system. | Source: {source}");
        }
    }
}
