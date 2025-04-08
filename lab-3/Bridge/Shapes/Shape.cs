using Bridge.Renders;

namespace Bridge.Shapes
{
    public abstract class Shape
    {
        protected IRender render;
        protected Shape(IRender render)
        {
            this.render = render;
        }
        public abstract void Draw();
    }
}
