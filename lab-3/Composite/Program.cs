using Composite.Command.Commands;
using Composite.Command;
using Composite;
using Composite.Iterator.Implementations;
using Composite.Visitor.Implementations;

public class Program
{
    public static void Main()
    {
        var invoker = new SequenceInvoker();
        var container = new LightElementNode("div", true, false);
        invoker.ExecuteCommand(
            new AddClass(container, "base-container")
        );

        var table = new LightElementNode("table", true, false);
        invoker.ExecuteCommand(
            new AddChild(container, table)
        );

        var headerRow = new LightElementNode("tr", true, false);

        var headerNickname = new LightElementNode("th", false, false);
        var textNickname = new LightTextNode();
        invoker.ExecuteCommand([
            new SetText(textNickname, "nickname"),
            new AddChild(headerNickname, textNickname)
        ]);

        var headerEmail = new LightElementNode("th", false, false);
        var textEmail = new LightTextNode();

        invoker.ExecuteCommand([
            new SetText(textEmail, "email"),
            new AddChild(headerEmail, textEmail),
            new AddChild(headerRow, headerNickname),
            new AddChild(headerRow, headerEmail)
        ]);

        var row1 = new LightElementNode("tr", true, false);

        var cell1Nickname = new LightElementNode("td", false, false);
        var text1Nickname = new LightTextNode();
        invoker.ExecuteCommand([
            new SetText(text1Nickname, "Artem"),
            new AddChild(cell1Nickname, text1Nickname)
        ]);

        var cell1Email = new LightElementNode("td", false, false);
        var text1Email = new LightTextNode();
        invoker.ExecuteCommand([
            new SetText(text1Email, "artem@gmail.com"),
            new AddChild(cell1Email, text1Email)
        ]);

        invoker.ExecuteCommand([
            new AddChild(row1, cell1Nickname),
            new AddChild(row1, cell1Email)
        ]);

        var row2 = new LightElementNode("tr", true, false);

        var cell2Nickname = new LightElementNode("td", false, false);
        var text2Nickname = new LightTextNode();
        invoker.ExecuteCommand([
            new SetText(text2Nickname, "Simon"),
            new AddChild(cell2Nickname, text2Nickname)
        ]);

        var cell2Email = new LightElementNode("td", false, false);
        var text2Email = new LightTextNode();
        invoker.ExecuteCommand([
            new SetText(text2Email, "simon@gmail.com"),
            new AddChild(cell2Email, text2Email)
        ]);

        invoker.ExecuteCommand([
            new AddChild(row2, cell2Nickname),
            new AddChild(row2, cell2Email)
        ]);

        invoker.ExecuteCommand([
            new AddChild(table, headerRow),
            new AddChild(table, row1),
            new AddChild(table, row2)
        ]);

        var hr = new LightElementNode("hr", false, true);

        invoker.ExecuteCommand(
            new AddChild(container, hr)
        );

        var p = new LightElementNode("p", true, false);
        var pText = new LightTextNode(string.Empty);
        invoker.ExecuteCommand([
            new SetText(pText, "Lorem ipsum dolor."),
            new AddClass(p, "after-table"),
            new AddChild(p, pText)
        ]);

        invoker.ExecuteCommand(
            new AddChild(container, p)
        );

        string html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();

        // Template
        Console.WriteLine("=== Template | Without Preparation ===");
        html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine(html);

        Console.WriteLine("\n=== Template | Preparating ===");
        container.Prepare();

        Console.WriteLine("\n=== Template | With Preparation ===");
        html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine(html);

        // Iterator
        Console.WriteLine("\n=== Iterator | Depth First Search ===");
        var dfs = container.GetIterator(root => new NodeIteratorDFS(root));
        while (dfs.MoveNext())
        {
            Console.WriteLine(dfs.Current?.TagName);
        }
        Console.WriteLine("\n=== Iterator | Resetting DFS Iterator ===");
        dfs.Reset();
        while (dfs.MoveNext())
        {
            Console.WriteLine(dfs.Current?.TagName);
        }

        Console.WriteLine("\n=== Template | Breadth First Search ===");
        var bfs = container.GetIterator(root => new NodeIteratorBFS(root));
        while (bfs.MoveNext())
        {
            Console.WriteLine(bfs.Current?.TagName);
        }
        Console.WriteLine("\n=== Template | Resetting BFS Iterator ===");
        bfs.Reset();
        while (bfs.MoveNext())
        {
            Console.WriteLine(bfs.Current?.TagName);
        }

        // Visitor
        Console.WriteLine("\n=== Visitor | Counted Tags ===");
        var pCounter = new TagCounter("p");
        var tdCounter = new TagCounter("td");
        container.Accept(pCounter);
        container.Accept(tdCounter);

        Console.WriteLine($"<p> count: {pCounter.Count}");
        Console.WriteLine($"<td> count: {tdCounter.Count}");

        Console.WriteLine("\n=== Visitor | Replaced Text ===");
        var nicknameReplace = new TextReplacer("nickname", "test");
        var emailReplace = new TextReplacer("email", "placeholder");
        container.Accept(nicknameReplace);
        container.Accept(emailReplace);

        html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine(html);

        Console.WriteLine("\n=== Visitor | Tree View ===");
        var treeViewer = new TreeViewer();
        container.Accept(treeViewer);

        // State
        Console.WriteLine("\n=== State | Switching Tag State to Hidden ===");
        table.Hide();
        html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine("\n" + html);

        Console.WriteLine("\n=== State | Switching Tag State to Shown ===");
        table.Show();
        html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine("\n" + html);

        // Command
        Console.WriteLine("\n=== Command | Reverting Commands ===");
        for (int i = 0; i < 4; i++) invoker.Undo();

        Console.WriteLine("\n=== Command | Reverted HTML ===");
        html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine(html);

        Console.WriteLine("\n=== Command | Reverting Commands ===");
        for (int i = 0; i < 2; i++) invoker.Undo();

        Console.WriteLine("\n=== Command | Reverted HTML ===");
        html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine(html);
    }
}