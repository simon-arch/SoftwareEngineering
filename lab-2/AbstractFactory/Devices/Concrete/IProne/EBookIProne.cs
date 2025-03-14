using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete.IProne
{
    public class EBookIProne : IEbook
    {
        public string Name => "EBook by IProne";
        public string Matrix => "Carta";
    }
}
