using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class SmartphoneBalaxy : ISmartphone
    {
        public string Name => "Smartphone by Balaxy";
        public string SIM => "Nano";
    }
}
