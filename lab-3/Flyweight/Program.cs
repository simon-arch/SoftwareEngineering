using System.Diagnostics;
using Flyweight;

public class Program
{
    static void Main()
    {
        Process proc = Process.GetCurrentProcess();
        long phys_mem_before = proc.WorkingSet64;
        long priv_mem_before = proc.PrivateMemorySize64;
        long gc_before = GC.GetTotalMemory(true);

        var root = Parser.Parse("book.txt");

        proc = Process.GetCurrentProcess();
        long phys_mem_after = proc.WorkingSet64;
        long priv_mem_after = proc.PrivateMemorySize64;
        long gc_after = GC.GetTotalMemory(true);

        var node = root;

        Console.WriteLine();
        Console.WriteLine($"┌─ Memory Usage Before : {gc_before / 1000} KB");
        Console.WriteLine($"├─ Memory Usage After  : {gc_after / 1000} KB");
        Console.WriteLine($"└─ Memory Usage Diff   : {(gc_after - gc_before) / 1000} KB");

        // String Pooling Disabled:
        // Composite Difference = 1638 KB
        // Flyweight Difference = 1439 KB
        // +14% Performance

        // String Pooling Enabled:
        // Composite Difference = 1484 KB
        // Flyweight Difference = 1436 KB
        // +3% Performance
    }
}