using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class EBookKiaomi : IEbook
    {
        public string Name => "EBook by Kiaomi";
        public string Matrix => "Pearl";
    }
}
