namespace Memento
{
    public class Memento
    {
        private readonly string content;
        public Memento(string content)
        {
            this.content = content;
        }

        public string GetState()
        {
            return content;
        }
    }

}
