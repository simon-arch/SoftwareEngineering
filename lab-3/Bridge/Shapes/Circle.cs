using Bridge.Renders;

namespace Bridge.Shapes
{
    public class Circle : Shape
    {
        public Circle(IRender render) : base(render) { }
        public override void Draw()
        {
            render.Render("Circle");
        }
    }
}
