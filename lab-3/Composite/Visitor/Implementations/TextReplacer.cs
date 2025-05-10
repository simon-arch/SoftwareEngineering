namespace Composite.Visitor.Implementations
{
    public class TextReplacer : IVisitor
    {
        private readonly string source;
        private readonly string target;

        public TextReplacer(string find, string replace)
        {
            source = find;
            target = replace;
        }

        public void Visit(LightElementNode node)
        {
            foreach (var child in node.Children) {
                child.Accept(this);
            }
        }

        public void Visit(LightTextNode node)
        {
            if (node.Text.Contains(source)) {
                node.Text = node.Text.Replace(source, target);
            }
        }
    }
}
