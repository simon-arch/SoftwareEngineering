namespace Composite.State
{
    public class ShowState : IRenderState
    {
        public void OnShow(LightElementNode node)
        {
            Console.WriteLine($"[State] <{node.TagName}> is already Shown");
        }

        public void OnHide(LightElementNode node)
        {
            Console.WriteLine($"[State] Hiding <{node.TagName}>");
            node.SetState(new HideState());
        }

        public string OnRender(LightElementNode node)
        {
            if (node.SelfClosing)
            {
                return $"<{node.TagName}{node.Classes}/>";
            }
            else
            {
                return $"<{node.TagName}{node.Classes}>{node.InnerHtml}</{node.TagName}>";
            }
        }
    }
}
