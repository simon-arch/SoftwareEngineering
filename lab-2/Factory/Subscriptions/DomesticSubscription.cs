namespace Factory.Subscriptions
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            MonthlyFee = 5.99m;
            MinimumSubscriptionPeriod = 1;
            Channels = new List<string> { "Local Channels", "Sports" };
            Features = new List<string> { "FullHD Quality" };
        }
    }
}
