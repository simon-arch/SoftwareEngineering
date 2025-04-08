namespace Flyweight.Context
{
    public class LightElementNode : LightNode
    {
        public List<string> Classes { get; set; } = new List<string>();
        public List<LightNode> Children { get; set; } = new List<LightNode>();

        private Flyweight flyweight;
        public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
        {
            flyweight = FlyweightFactory.GetFlyweight(tagName, isBlock, isSelfClosing);
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
                if (flyweight.SelfClosing)
                {
                    return $"<{flyweight.TagName}{classes}/>";
                }
                else
                {
                    return $"<{flyweight.TagName}{classes}>{InnerHtml}</{flyweight.TagName}>";
                }
            }
        }

        public override string InnerHtml => string.Join("", Children.Select(child => child.OuterHtml));
    }
}
