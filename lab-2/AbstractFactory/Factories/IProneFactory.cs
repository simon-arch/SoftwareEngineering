using AbstractFactory.Products.Abstract;
using AbstractFactory.Products.Concrete.IProne;

namespace AbstractFactory.Factories
{
    public class IProneFactory : IAbstractFactory
    {
        public IEbook CreateEbook()
        {
            return new EBookIProne();
        }

        public ILaptop CreateLaptop()
        {
            return new LaptopIProne();
        }

        public INetbook CreateNetbook()
        {
            return new NetbookIProne();
        }

        public ISmartphone CreateSmartphone()
        {
            return new SmartphoneIProne();
        }
    }
}
