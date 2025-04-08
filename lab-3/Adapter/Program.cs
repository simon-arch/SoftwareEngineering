using Adapter;
public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = new Logger();

        logger.Log("Log message example.");
        logger.Warn("Warn message example.");
        logger.Error("Error message example.");

        logger = new FileLogger("demo.log");

        logger.Log("Log message example.");
        logger.Warn("Warn message example.");
        logger.Error("Error message example.");
    }
}