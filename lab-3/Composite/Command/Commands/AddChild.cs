namespace Composite.Command.Commands
{
    public class AddChild : INodeCommand
    {
        private LightElementNode node;
        private LightNode child;
        public AddChild(LightElementNode elementNode, LightNode childNode)
        {
            node = elementNode;
            child = childNode;
        }
        public void Execute() 
        {
            if (!node.Children.Contains(child)) {
                node.AddChild(child);
            }
        }
        public void Undo() => node.Children.Remove(child);
    }
}
