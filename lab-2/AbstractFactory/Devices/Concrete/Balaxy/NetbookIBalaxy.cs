using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class NetbookBalaxy : INetbook
    {
        public string Name => "Netbook by Balaxy";
        public string Platform => "iOS";
    }
}
