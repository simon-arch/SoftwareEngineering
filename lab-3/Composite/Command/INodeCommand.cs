namespace Composite.Command
{
    public interface INodeCommand
    {
        void Execute();
        void Undo();
    }
}
