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
            string classes = node.Classes.Count > 0 ? $" class='{string.Join(" ", node.Classes)}'" : string.Empty;
            if (node.SelfClosing)
            {
                return $"<{node.TagName}{classes}/>";
            }
            else
            {
                return $"<{node.TagName}{classes}>{node.InnerHtml}</{node.TagName}>";
            }
        }
    }
}
