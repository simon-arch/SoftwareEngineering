// using Composite;
using Flyweight.Context;

namespace Flyweight
{
    public static class Parser
    {
        public static LightElementNode Parse(string filePath)
        {
            var root = new LightElementNode("div", true, false);

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()!) != null)
                {
                    LightElementNode node;

                    if (line.Length == 0)
                    {
                        node = new LightElementNode(new string("br".ToCharArray()), false, true);
                    }
                    else if (line[0] == ' ')
                    {
                        node = new LightElementNode(new string("blockquote".ToCharArray()), true, false);
                        node.AddChild(new LightTextNode(line.Trim()));
                    }
                    else if (line.Length < 20)
                    {
                        node = new LightElementNode(new string("h2".ToCharArray()), true, false);
                        node.AddChild(new LightTextNode(line));
                    }
                    else
                    {
                        node = new LightElementNode(new string("p".ToCharArray()), true, false);
                        node.AddChild(new LightTextNode(line));
                    }

                    root.AddChild(node);
                }
            }

            return root;
        }
    }
}
