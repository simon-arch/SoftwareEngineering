using Factory.Subscriptions;

namespace Factory
{
    public class WebSite : IFactoryCreator
    {
        public Subscription CreateSubscription(decimal proposedFee, int proposedPeriod)
        {
            if (proposedFee >= 30.00m && proposedPeriod >= 6)
                return new PremiumSubscription();
            else
                return new DomesticSubscription();
        }
    }

    public class MobileApp : IFactoryCreator
    {
        public Subscription CreateSubscription(decimal proposedFee, int proposedPeriod)
        {
            if (proposedFee >= 15.00m && proposedPeriod >= 3)
                return new EducationalSubscription();
            else
                return new DomesticSubscription();
        }
    }

    public class ManagerCall : IFactoryCreator
    {
        public Subscription CreateSubscription(decimal proposedFee, int proposedPeriod)
        {
            if (proposedFee >= 40.00m && proposedPeriod >= 6)
                return new PremiumSubscription();
            else if (proposedFee >= 25.00m && proposedPeriod >= 3)
                return new EducationalSubscription();
            else
                return new DomesticSubscription();
        }
    }
}