using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class EBookBalaxy : IEbook
    {
        public string Name => "EBook by Balaxy";
        public string Matrix => "Kaleido";
    }
}
