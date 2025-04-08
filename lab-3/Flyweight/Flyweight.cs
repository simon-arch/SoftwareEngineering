namespace Flyweight
{
    public class Flyweight
    {
        public string TagName { get; }
        public bool Block { get; }
        public bool SelfClosing { get; }

        public Flyweight(string tagName, bool block, bool selfClosing)
        {
            TagName = tagName;
            Block = block;
            SelfClosing = selfClosing;
        }
    }
}
