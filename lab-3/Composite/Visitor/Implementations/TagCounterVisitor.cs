namespace Composite.Visitor.Implementations
{
    public class TagCounter : IVisitor
    {
        private readonly string tagName;
        public int Count { get; private set; }

        public TagCounter(string target)
        {
            tagName = target;
            Count = 0;
        }

        public void Visit(LightElementNode node)
        {
            if (node.TagName == tagName) {
                Count++;
            }

            foreach (var child in node.Children) {
                child.Accept(this);
            }
        }

        public void Visit(LightTextNode node) {
            return;
        }
    }
}
