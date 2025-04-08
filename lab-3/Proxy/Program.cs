using Proxy;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        ITextReader reader = new SmartTextReader();
        ITextReader checker = new SmartTextChecker(reader);
        ITextReader locker = new SmartTextReaderLocker(checker, @"ignore");

        string filePath1 = "log.txt";
        string filePath2 = "ignore.txt";

        Console.WriteLine("== File 1 ==");
        char[][] result1 = locker.Read(filePath1);
        Console.WriteLine("\n== File Output ==");
        PrintArray(result1);

        Console.WriteLine("\n" + new string('─', 50));

        Console.WriteLine("\n== File 2 ==");
        char[][] result2 = locker.Read(filePath2);
        Console.WriteLine("\n== File Output ==");
        PrintArray(result2);
    }
    public static void PrintArray(char[][] array)
    {
        if (array.Length > 0)
        {
            foreach (var row in array)
            {
                foreach (var chr in row)
                {
                    Console.Write(chr);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("[empty array]");
        }
    }
}