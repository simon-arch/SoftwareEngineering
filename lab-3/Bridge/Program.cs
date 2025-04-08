using Bridge.Renders;
using Bridge.Shapes;

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("┌── Vector Rendering");
        IRender VectorRender = new VectorRender();
        Shape CircleVector = new Circle(VectorRender);
        Shape SquareVector = new Square(VectorRender);
        Shape TriangleVector = new Triangle(VectorRender);

        Console.Write("├ "); CircleVector.Draw();
        Console.Write("├ "); SquareVector.Draw();
        Console.Write("└ "); TriangleVector.Draw();

        Console.WriteLine("\n┌── Raster Rendering");
        IRender RasterRender = new RasterRender();
        Shape CircleRaster = new Circle(RasterRender);
        Shape SquareRaster = new Square(RasterRender);
        Shape TriangleRaster = new Triangle(RasterRender);

        Console.Write("├ "); CircleRaster.Draw();
        Console.Write("├ "); SquareRaster.Draw();
        Console.Write("└ "); TriangleRaster.Draw();
    }
}