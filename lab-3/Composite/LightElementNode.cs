﻿using Composite.Iterator;
using Composite.Visitor;
using Composite.State;

namespace Composite
{
    public class LightElementNode : LightNode, IAggregate<LightElementNode>, IVisitable
    {
        public string TagName { get; set; }
        public bool Block { get; set; }
        public bool SelfClosing { get; set; }
        public List<string> classes = new List<string>();
        private Dictionary<string, string> styles = new Dictionary<string, string>();
        public List<LightNode> Children { get; set; } = new List<LightNode>();
        public string Classes { get; set; } = string.Empty;
        public string Styles { get; set; } = string.Empty;
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
        public void AddClass(string classname) {
            if (classes.Contains(classname)) return;
            classes.Add(classname);
        }
        public void RemoveClass(string classname) => classes.Remove(classname);
        public override string OuterHtml => renderState.OnRender(this);
        public override string InnerHtml => string.Join("", Children.Select(child => child.OuterHtml));
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
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
            Styles = $" style='{string.Join("; ", styles.Select(s => $"{s.Key}: {s.Value}"))}'";
            Log("OnStylesApplied", $"Style List applied: {Styles}");
        }
        protected override void OnClassListApplied()
        {
            Classes = $" class='{string.Join(" ", classes)}'";
            Log("OnClassListApplied", $"Class List applied: {Classes}");
        }
        protected override bool HasClasses() => classes.Count > 0;
        protected override bool HasStyles() => styles.Count > 0;
        private void Log(string prefix, string message)
        {
            Console.WriteLine($"[{TagName}][{prefix}] {message}");
        }
        public IIterator<LightElementNode> GetIterator(Func<LightElementNode, IIterator<LightElementNode>> iterator)
        {
            return iterator(this);
        }
    }
}
