namespace Composite.Visitor.Implementations
{
    public class TreeViewer : IVisitor
    {
        private readonly Stack<bool> nodes = new Stack<bool>();

        public void Visit(LightElementNode node)
        {
            PrintPrefix();
            Console.WriteLine(node.TagName);

            for (int i = 0; i < node.Children.Count; i++) {
                bool isLast = i == node.Children.Count - 1;
                nodes.Push(isLast);
                node.Children[i].Accept(this);
                nodes.Pop();
            }
        }

        public void Visit(LightTextNode node)
        {
            PrintPrefix();
            Console.WriteLine(node.Text);
        }

        private void PrintPrefix()
        {
            if (nodes.Count == 0) return;

            var items = nodes.Reverse().ToArray();
            for (int i = 0; i < items.Length - 1; i++) {
                Console.Write(items[i] ? "  " : "│ ");
            }

            Console.Write(items[^1] ? "└─" : "├─");
        }
    }
}
