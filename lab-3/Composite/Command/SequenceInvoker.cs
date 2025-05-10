namespace Composite.Command
{
    public class SequenceInvoker
    {
        private Stack<INodeCommand> history = new Stack<INodeCommand>();
        public void ExecuteCommand(INodeCommand command) => PushCommand(command);
        public void ExecuteCommand(List<INodeCommand> commands)
        {
            foreach (INodeCommand command in commands) {
                PushCommand(command);
            }
        }
        private void PushCommand(INodeCommand command) 
        {
            command.Execute();
            history.Push(command);
        }
        public void Undo()
        {
            if (history.Count > 0)
            {
                var command = history.Pop();
                Console.WriteLine($"[Undo] Reverting {command.GetType().Name}");
                command.Undo();
            }
        }
    }
}
