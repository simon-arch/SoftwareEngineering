using Composite.Iterator;
using Composite.Iterator.Implementations;

namespace Composite
{
    public class LightElementNode : LightNode, IAggregate<LightElementNode>
    {
        public string TagName { get; set; }
        public bool Block { get; set; }
        public bool SelfClosing { get; set; }
        public List<string> Classes { get; set; } = new List<string>();
        public List<LightNode> Children { get; set; } = new List<LightNode>();
        public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
        {
            TagName = tagName;
            Block = isBlock;
            SelfClosing = isSelfClosing;
        }
        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }
        public override string OuterHtml
        {
            get
            {
                string classes = Classes.Count > 0 ? $" class='{string.Join(" ", Classes)}'" : string.Empty;
                if (SelfClosing)
                {
                    return $"<{TagName}{classes}/>";
                }
                else
                {
                    return $"<{TagName}{classes}>{InnerHtml}</{TagName}>";
                }
            }
        }
        public override string InnerHtml => string.Join("", Children.Select(child => child.OuterHtml));
        public IIterator<LightElementNode> GetIterator(Func<LightElementNode, IIterator<LightElementNode>> iterator)
        {
            return iterator(this);
        }
    }
}
