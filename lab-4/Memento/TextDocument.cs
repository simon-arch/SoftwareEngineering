namespace Memento
{
    public class TextDocument
    {
        public string Content { get; set; } = string.Empty;

        public Memento CreateMemento()
        {
            return new Memento(Content);
        }

        public void Restore(Memento memento)
        {
            Content = memento.GetState();
        }
    }
}