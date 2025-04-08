using Bridge.Renders;

namespace Bridge.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(IRender render) : base(render) { }
        public override void Draw()
        {
            render.Render("Triangle");
        }
    }
}
