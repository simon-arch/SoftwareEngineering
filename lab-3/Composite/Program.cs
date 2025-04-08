using Composite;
public class Program
{
    public static void Main()
    {
        var container = new LightElementNode("div", true, false);
        container.Classes.Add("base-container");

        var table = new LightElementNode("table", true, false);

        var headerRow = new LightElementNode("tr", true, false);

        var headerNickname = new LightElementNode("th", false, false);
        headerNickname.AddChild(new LightTextNode("nickname"));

        var headerEmail = new LightElementNode("th", false, false);
        headerEmail.AddChild(new LightTextNode("email"));

        headerRow.AddChild(headerNickname);
        headerRow.AddChild(headerEmail);

        var row1 = new LightElementNode("tr", true, false);

        var cell1Nickname = new LightElementNode("td", false, false);
        cell1Nickname.AddChild(new LightTextNode("Artem"));

        var cell1Email = new LightElementNode("td", false, false);
        cell1Email.AddChild(new LightTextNode("artem@gmail.com"));

        row1.AddChild(cell1Nickname);
        row1.AddChild(cell1Email);

        var row2 = new LightElementNode("tr", true, false);

        var cell2Nickname = new LightElementNode("td", false, false);
        cell2Nickname.AddChild(new LightTextNode("Simon"));

        var cell2Email = new LightElementNode("td", false, false);
        cell2Email.AddChild(new LightTextNode("simon@gmail.com"));

        row2.AddChild(cell2Nickname);
        row2.AddChild(cell2Email);

        table.AddChild(headerRow);
        table.AddChild(row1);
        table.AddChild(row2);

        container.AddChild(table);

        var hr = new LightElementNode("hr", false, true);
        container.AddChild(hr);

        var p = new LightElementNode("p", true, false);
        p.Classes.Add("after-table");
        p.AddChild(new LightTextNode("Lorem ipsum dolor."));

        container.AddChild(p);

        string html = System.Xml.Linq.XElement.Parse(container.OuterHtml).ToString();
        Console.WriteLine(html);
    }
}