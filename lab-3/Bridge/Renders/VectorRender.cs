namespace Bridge.Renders
{
    public class VectorRender : IRender
    {
        public void Render(string shape)
        {
            Console.WriteLine($"Rendering {shape} in a vector format.");
        }
    }
}
