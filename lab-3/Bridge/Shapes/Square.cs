using Bridge.Renders;

namespace Bridge.Shapes
{
    public class Square : Shape
    {
        public Square(IRender render) : base(render) { }
        public override void Draw()
        {
            render.Render("Square");
        }
    }
}
