namespace Bridge.Renders
{
    public class RasterRender : IRender
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Rendering {shape} in a raster format.");
        }
    }
}
