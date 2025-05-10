namespace Composite.State
{
    public interface IRenderState
    {
        void OnShow(LightElementNode node);
        void OnHide(LightElementNode node);
        string OnRender(LightElementNode node);
    }
}
