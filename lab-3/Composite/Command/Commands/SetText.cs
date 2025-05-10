namespace Composite.Command.Commands
{
    public class SetText : INodeCommand
    {
        private LightTextNode node;
        private string newText;
        private string oldText;
        public SetText(LightTextNode textNode, string text)
        {
            node = textNode;
            newText = text;
            oldText = textNode.Text;
        }

        public void Execute() => node.Text = newText;
        public void Undo() => node.Text = oldText;
    }
}
