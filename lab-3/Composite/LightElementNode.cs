using Composite.Visitor;
﻿using Composite.State;
﻿using Composite.Iterator;
using Composite.Iterator.Implementations;

namespace Composite
{
    public class LightElementNode : LightNode, IAggregate<LightElementNode>, IVisitable
    {
        public string TagName { get; set; }
        public bool Block { get; set; }
        public bool SelfClosing { get; set; }
        public List<string> Classes { get; set; } = new List<string>();
        public Dictionary<string, string> Styles { get; set; } = new Dictionary<string, string>();
        public List<LightNode> Children { get; set; } = new List<LightNode>();
        private string classes = string.Empty;
        private string styles = string.Empty;
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
        public override void Accept(IVisitor visitor)
        {
            get
            {
                if (SelfClosing)
                {
                    return $"<{TagName}{classes}{styles}/>";
                }
                else
                {
                    return $"<{TagName}{classes}{styles}>{InnerHtml}</{TagName}>";
                }
            }
        }
        public override string InnerHtml => string.Join("", Children.Select(child => child.OuterHtml));
        protected override void OnStart()
        {
            Console.WriteLine();
            Log("OnStart", "Prepare Started.");
        }
        protected override void OnEnd()
        {
            Log("OnEnd", "Prepare Ended.");
            foreach (LightNode child in Children) {
                child.Prepare();
            }
        }
        protected override void OnStylesApplied()
        {
            styles = $" style='{string.Join("; ", Styles.Select(s => $"{s.Key}: {s.Value}"))}'";
            Log("OnStylesApplied", $"Style List applied: {styles}");
        }
        protected override void OnClassListApplied()
        {
            classes = $" class='{string.Join(" ", Classes)}'";
            Log("OnClassListApplied", $"Class List applied: {classes}");
        }
        protected override bool HasClasses() => Classes.Count > 0;
        protected override bool HasStyles() => Styles.Count > 0;
        private void Log(string prefix, string message)
        {
            Console.WriteLine($"[{TagName}][{prefix}] {message}");
            visitor.Visit(this);
        }
        public override string InnerHtml => string.Join("", Children.Select(child => child.OuterHtml));
        public IIterator<LightElementNode> GetIterator(Func<LightElementNode, IIterator<LightElementNode>> iterator)
        {
            return iterator(this);
        }
    }
}
