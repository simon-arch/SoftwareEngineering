namespace Memento
{
    public class DocumentCaretaker
    {
        private TextEditor editor;
        private Stack<Memento> snapshots = new Stack<Memento>();
        public DocumentCaretaker(TextEditor editor)
        {
            this.editor = editor;
        }

        public void Save()
        {
            snapshots.Push(editor.Document.CreateMemento());
        }

        public void Undo()
        {
            if (snapshots.Count > 0)
            {
                var memento = snapshots.Pop();
                editor.Document.Restore(memento);
                Console.WriteLine($"[Caretaker ] Undo. Content changed back to: {memento.GetState()}");
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("[Caretaker ] Currently available snapshots:");
            if (snapshots.Count == 0) Console.WriteLine("\t\t[none]");
            foreach (var memento in snapshots.Reverse())
                Console.WriteLine("\t\t"+memento.GetState());
        }
    }
}
