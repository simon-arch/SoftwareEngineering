namespace Composite.State
{
    public class HideState : IRenderState
    {
        public void OnShow(LightElementNode node)
        {
            Console.WriteLine($"[State] Showing <{node.TagName}>");
            node.SetState(new ShowState());
        }

        public void OnHide(LightElementNode node)
        {
            Console.WriteLine($"[State] <{node.TagName}> is already Hidden");
        }

        public string OnRender(LightElementNode node)
        {
            return string.Empty;
        }
    }
}
