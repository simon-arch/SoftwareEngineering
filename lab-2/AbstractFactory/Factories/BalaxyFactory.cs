using AbstractFactory.Products.Abstract;
using AbstractFactory.Products.Concrete.IProne;

namespace AbstractFactory.Factories
{
    public class BalaxyFactory : IAbstractFactory
    {
        public IEbook CreateEbook()
        {
            return new EBookBalaxy();
        }

        public ILaptop CreateLaptop()
        {
            return new LaptopBalaxy();
        }

        public INetbook CreateNetbook()
        {
            return new NetbookBalaxy();
        }

        public ISmartphone CreateSmartphone()
        {
            return new SmartphoneBalaxy();
        }
    }
}
