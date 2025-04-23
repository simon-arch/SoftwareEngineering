namespace Composite.Strategy
{
    public class LightImageNode : LightElementNode
    {
        public string Src { get; set; }
        private ISourceStrategy sourceStrategy;

        public LightImageNode(string src) : base("img", false, true)
        {
            Src = src;
            sourceStrategy = GetStrategy(src);
        }

        private ISourceStrategy GetStrategy(string src)
        {
            return (src.StartsWith("http://") || src.StartsWith("https://"))
                   ? new WebSourceStrategy()
                   : new FileSourceStrategy();
        }

        public void LoadImage()
        {
            sourceStrategy.Load(Src);
        }

        public override string OuterHtml
        {
            get
            {
                return $"<{TagName} src='{Src}' />";
            }
        }
    }
}
