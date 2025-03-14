using AbstractFactory.Products.Abstract;
using AbstractFactory.Products.Concrete.IProne;

namespace AbstractFactory.Factories
{
    public class KiaomiFactory : IAbstractFactory
    {
        public IEbook CreateEbook()
        {
            return new EBookKiaomi();
        }

        public ILaptop CreateLaptop()
        {
            return new LaptopKiaomi();
        }

        public INetbook CreateNetbook()
        {
            return new NetbookKiaomi();
        }

        public ISmartphone CreateSmartphone()
        {
            return new SmartphoneKiaomi();
        }
    }
}
