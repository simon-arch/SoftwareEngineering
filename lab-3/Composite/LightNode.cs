namespace Composite
{
    public abstract class LightNode
    {
        public abstract string OuterHtml { get; }
        public abstract string InnerHtml { get; }
        protected virtual void OnStart() { }
        protected virtual void OnEnd() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnTextRendered() { }
        public void Prepare()
        {
            OnStart();
            if (HasClasses()) OnClassListApplied();
            if (HasStyles()) OnStylesApplied();
            if (HasText()) OnTextRendered();
            OnEnd();
        }
        protected virtual bool HasClasses() => false;
        protected virtual bool HasStyles() => false;
        protected virtual bool HasText() => false;
    }
}
