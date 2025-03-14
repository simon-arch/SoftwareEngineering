using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class LaptopKiaomi : ILaptop
    {
        public string Name => "Laptop by Kiaomi";
        public string Camera => "4K";
    }
}
