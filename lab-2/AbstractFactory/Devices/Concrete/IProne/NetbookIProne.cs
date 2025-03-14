using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class NetbookIProne : INetbook
    {
        public string Name => "Netbook by IProne";
        public string Platform => "Linux";
    }
}
