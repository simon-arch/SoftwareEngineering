using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class SmartphoneIProne : ISmartphone
    {
        public string Name => "Smartphone by IProne";
        public string SIM => "Micro";
    }
}
