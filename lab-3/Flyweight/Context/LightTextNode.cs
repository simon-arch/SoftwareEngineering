﻿namespace Flyweight.Context
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
    }
}