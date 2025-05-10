using Composite.Command.Commands;
using Composite.Command;
using Composite;
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

        Console.WriteLine("=== Initial HTML ===");
        string html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine(html);

        Console.WriteLine("\n=== Reverting Commands ===");
        for (int i = 0; i < 4; i++) invoker.Undo();

        Console.WriteLine("\n=== Reverted HTML ===");
        html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine(html);

        Console.WriteLine("\n=== Reverting Commands ===");
        for (int i = 0; i < 2; i++) invoker.Undo();

        Console.WriteLine("\n=== Reverted HTML ===");
        html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine(html);
    }
}