namespace Composite.Iterator.Implementations
{
    public class NodeIteratorBFS : IIterator<LightElementNode>
    {
        private readonly LightElementNode root;
        private Queue<LightElementNode> queue;
        private HashSet<LightElementNode> visited;
        public LightElementNode? Current { get; private set; }

        public NodeIteratorBFS(LightElementNode root)
        {
            this.root = root;
            visited = new HashSet<LightElementNode>();
            queue = new Queue<LightElementNode>();
            queue.Enqueue(root);
        }

        public bool MoveNext()
        {
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (!visited.Contains(node))
                {
                    visited.Add(node);
                    Current = node;
                    foreach (var neighbor in node.Children.OfType<LightElementNode>())
                    {
                        if (!visited.Contains(neighbor))
                        {
                            queue.Enqueue(neighbor);
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public void Reset()
        {
            visited.Clear();
            queue.Clear();
            queue.Enqueue(root);
            Current = null;
        }
    }
}
