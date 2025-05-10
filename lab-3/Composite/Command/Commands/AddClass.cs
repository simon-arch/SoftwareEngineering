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
            if (!node.Classes.Contains(classname)) {
                node.Classes.Add(classname);
            }
        }
        public void Undo() => node.Classes.Remove(classname);
    }
}
