using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class SmartphoneKiaomi : ISmartphone
    {
        public string Name => "Smartphone by Kiaomi";
        public string SIM => "Mini";
    }
}
