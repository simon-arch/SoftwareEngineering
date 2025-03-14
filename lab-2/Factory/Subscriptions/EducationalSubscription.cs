namespace Factory.Subscriptions
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            MonthlyFee = 14.99m;
            MinimumSubscriptionPeriod = 2;
            Channels = new List<string> { "Webinars", "Documentaries" };
            Features = new List<string> { "Certificates", "Courses" };
        }
    }
}
