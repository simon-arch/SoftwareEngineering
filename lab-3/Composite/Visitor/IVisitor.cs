namespace Composite.Visitor
{
    public interface IVisitor
    {
        public void Visit(LightTextNode node);
        public void Visit(LightElementNode node);
    }
}
