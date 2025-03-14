using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Factories
{
    public interface IAbstractFactory
    {
        public ILaptop CreateLaptop();
        public INetbook CreateNetbook();
        public IEbook CreateEbook();
        public ISmartphone CreateSmartphone();
    }
}
