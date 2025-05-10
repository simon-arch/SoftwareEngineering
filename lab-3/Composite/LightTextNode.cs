namespace Composite
{
    public class LightTextNode : LightNode
    {
        public string Text { get; set; }
        public LightTextNode(string text)
        {
            Text = text;
        }
        public override string OuterHtml => Text;
        public override string InnerHtml => Text;
        protected override void OnTextRendered()
        {
            Console.WriteLine($"[OnTextRendered] {Text}");
            if (Text.Contains("@")) Text = "Email Removed";
        }
        protected override bool HasText() => Text.Length > 0;
    }
}