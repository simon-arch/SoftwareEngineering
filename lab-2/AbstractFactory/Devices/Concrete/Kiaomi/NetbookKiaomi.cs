using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class NetbookKiaomi : INetbook
    {
        public string Name => "Netbook by Kiaomi";
        public string Platform => "Bimbows";
    }
}
