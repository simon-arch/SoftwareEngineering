using CoR.Handlers;
internal class Program
{
    private static void Main(string[] args)
    {
        var business  = new BusinessSupport();
        var customer  = new CustomerSupport();
        var media     = new MediaSupport();
        var security  = new SecuritySupport();
        var technical = new TechnicalSupport();

        business.SetNextHandler(customer)
                .SetNextHandler(media)
                .SetNextHandler(security)
                .SetNextHandler(technical)
                .SetNextHandler(business);

        business.Handle();
        Console.WriteLine("Wait while support team gets in touch with you.");
    }
}