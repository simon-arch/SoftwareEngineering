namespace Composite.Iterator.Implementations
{
    public class NodeIteratorDFS : IIterator<LightElementNode>
    {
        private readonly LightElementNode root;
        private Stack<IEnumerator<LightElementNode>> stack;
        public LightElementNode? Current { get; private set; }

        public NodeIteratorDFS(LightElementNode root)
        {
            this.root = root;
            stack = new Stack<IEnumerator<LightElementNode>>();
            Reset();
        }

        public bool MoveNext()
        {
            while (stack.Count > 0)
            {
                var enumerator = stack.Peek();
                if (enumerator.MoveNext())
                {
                    Current = enumerator.Current;
                    if (Current.Children.Count > 0)
                    {
                        stack.Push(Current.Children.OfType<LightElementNode>().GetEnumerator());
                    }
                    return true;
                }
                else
                {
                    stack.Pop();
                }
            }
            return false;
        }

        public void Reset()
        {
            stack.Clear();
            stack.Push(new List<LightElementNode> { root }.GetEnumerator());
        }
    }
}
