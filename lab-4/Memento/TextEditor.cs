namespace Memento
{
    public class TextEditor
    {
        public TextDocument Document { get; set; }
        public DocumentCaretaker Manager { get; set; }
        public TextEditor()
        {
            Document = new TextDocument();
            Manager = new DocumentCaretaker(this);
        }

        public string GetContent()
        {
            return "[Originator] Current content: " + Document.Content;
        }

        public void SetContent(string content)
        {
            Console.WriteLine($"[Originator] Content changed to: {content}");
            Document.Content = content;
            Manager.Save();
        }

        public void Undo()
        {
            Manager.Undo();
        }
    }
}
