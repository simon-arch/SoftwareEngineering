using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class LaptopBalaxy : ILaptop
    {
        public string Name => "Laptop by Balaxy";
        public string Camera => "FullHD";
    }
}
