using Composite;
using Composite.Iterator.Implementations;
public class Program
{
    public static void Main()
    {
        var container = new LightElementNode("div-a", true, false);
        container.Classes.Add("base-container");

        var table = new LightElementNode("table-a.1", true, false);

        var headerRow = new LightElementNode("tr-a.1.A", true, false);

        var headerNickname = new LightElementNode("th-a.1.A.I", false, false);
        headerNickname.AddChild(new LightTextNode("nickname"));

        var headerEmail = new LightElementNode("th-a.1.A.II", false, false);
        headerEmail.AddChild(new LightTextNode("email"));

        headerRow.AddChild(headerNickname);
        headerRow.AddChild(headerEmail);

        var row1 = new LightElementNode("tr-a.1.B", true, false);

        var cell1Nickname = new LightElementNode("td-a.1.B.I", false, false);
        cell1Nickname.AddChild(new LightTextNode("Artem"));

        var cell1Email = new LightElementNode("td-a.1.B.II", false, false);
        cell1Email.AddChild(new LightTextNode("artem@gmail.com"));

        row1.AddChild(cell1Nickname);
        row1.AddChild(cell1Email);

        var row2 = new LightElementNode("tr-a.1.C", true, false);

        var cell2Nickname = new LightElementNode("td-a.1.C.I", false, false);
        cell2Nickname.AddChild(new LightTextNode("Simon"));

        var cell2Email = new LightElementNode("td-a.1.C.II", false, false);
        cell2Email.AddChild(new LightTextNode("simon@gmail.com"));

        row2.AddChild(cell2Nickname);
        row2.AddChild(cell2Email);

        table.AddChild(headerRow);
        table.AddChild(row1);
        table.AddChild(row2);

        container.AddChild(table);

        var hr = new LightElementNode("hr-a.2", false, true);
        container.AddChild(hr);

        var p = new LightElementNode("p-a.3", true, false);
        p.Classes.Add("after-table");
        p.AddChild(new LightTextNode("Lorem ipsum dolor."));

        container.AddChild(p);
        var html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();

        Console.WriteLine("=== Initial HTML (Tags renamed for further clarity) ===");
        Console.WriteLine(html);

        Console.WriteLine("\n=== Depth First Search ===");
        var dfs = container.GetIterator(root => new NodeIteratorDFS(root));
        while (dfs.MoveNext())
        {
            Console.WriteLine(dfs.Current?.TagName);
        }
        Console.WriteLine("\n=== Resetting DFS Iterator ===");
        dfs.Reset();
        while (dfs.MoveNext())
        {
            Console.WriteLine(dfs.Current?.TagName);
        }

        Console.WriteLine("\n=== Breadth First Search ===");
        var bfs = container.GetIterator(root => new NodeIteratorBFS(root));
        while (bfs.MoveNext()) {
            Console.WriteLine(bfs.Current?.TagName);
        }
        Console.WriteLine("\n=== Resetting BFS Iterator ===");
        bfs.Reset();
        while (bfs.MoveNext())
        {
            Console.WriteLine(bfs.Current?.TagName);
        }
    }
}