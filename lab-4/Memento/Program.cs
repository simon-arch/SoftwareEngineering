using Memento;

internal class Program
{
    private static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();

        Console.WriteLine("=== Setting Content ===");
        editor.SetContent("Changed Content");
        editor.Manager.ShowHistory();
        Console.WriteLine(editor.GetContent());

        Console.WriteLine("\n=== Setting Content ===");
        editor.SetContent("Changed Placeholder");
        editor.Manager.ShowHistory();
        Console.WriteLine(editor.GetContent());

        Console.WriteLine("\n=== Setting Content ===");
        editor.SetContent("Changed Again");
        editor.Manager.ShowHistory();
        Console.WriteLine(editor.GetContent());

        Console.WriteLine("\n=== Content Undo ===");
        editor.Undo();
        editor.Manager.ShowHistory();
        Console.WriteLine(editor.GetContent());

        Console.WriteLine("\n=== Content Undo ===");
        editor.Undo();
        editor.Manager.ShowHistory();
        Console.WriteLine(editor.GetContent());

        Console.WriteLine("\n=== Content Undo ===");
        editor.Undo();
        editor.Manager.ShowHistory();
        Console.WriteLine(editor.GetContent());
    }
}