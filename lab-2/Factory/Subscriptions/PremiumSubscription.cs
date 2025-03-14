namespace Factory.Subscriptions
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            MonthlyFee = 25.99m;
            MinimumSubscriptionPeriod = 3;
            Channels = new List<string> { "Sports", "News", "Music" };
            Features = new List<string> { "4K", "No Ads" };
        }
    }
}
