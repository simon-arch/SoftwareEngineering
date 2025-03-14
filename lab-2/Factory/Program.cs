using Factory.Subscriptions;
using Factory;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("== Website App Factory ==");
        IFactoryCreator websiteFactory = new WebSite();
        Subscription webSub = websiteFactory.CreateSubscription(22.00m, 5);
        Console.WriteLine("┌ Proposed Fee:    $22.00");
        Console.WriteLine("└ Proposed Period: 5 months");
        Console.WriteLine(webSub.ToString());


        Console.WriteLine("== Mobile App Factory ==");
        IFactoryCreator mobileAppFactory = new MobileApp();
        Subscription mobSub = mobileAppFactory.CreateSubscription(18.00m, 3);
        Console.WriteLine("┌ Proposed Fee:    $18.00");
        Console.WriteLine("└ Proposed Period: 3 months");
        Console.WriteLine(mobSub.ToString());


        Console.WriteLine("== Manager Call Factory ==");
        IFactoryCreator managerCallFactory = new ManagerCall();
        Subscription callSub = managerCallFactory.CreateSubscription(50.00m, 6);
        Console.WriteLine("┌ Proposed Fee:    $50.00");
        Console.WriteLine("└ Proposed Period: 6 months");
        Console.WriteLine(callSub.ToString());
    }
}
