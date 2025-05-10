namespace Composite.Command.Commands
{
    public class AddClass : INodeCommand
    {
        private LightElementNode node;
        private string classname;
        public AddClass(LightElementNode elementNode, string className)
        {
            node = elementNode;
            classname = className;
        }
        public void Execute()
        {
            node.AddClass(classname);
        }
        public void Undo() => node.RemoveClass(classname);
    }
}
