using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class LaptopIProne : ILaptop
    {
        public string Name => "Laptop by IProne";
        public string Camera => "HD";
    }
}
