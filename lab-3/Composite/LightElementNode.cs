using Composite.State;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public bool Block { get; set; }
        public bool SelfClosing { get; set; }
        public List<string> Classes { get; set; } = new List<string>();
        public List<LightNode> Children { get; set; } = new List<LightNode>();
        private IRenderState renderState;
        public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
        {
            TagName = tagName;
            Block = isBlock;
            SelfClosing = isSelfClosing;
            renderState = new ShowState();
        }
        public void SetState(IRenderState state) => renderState = state;
        public void Show() => renderState.OnShow(this);
        public void Hide() => renderState.OnHide(this);
        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }
        public override string OuterHtml => renderState.OnRender(this);
        public override string InnerHtml => string.Join("", Children.Select(child => child.OuterHtml));
    }
}
