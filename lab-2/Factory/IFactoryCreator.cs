using Factory.Subscriptions;

namespace Factory
{
    interface IFactoryCreator
    {
        public Subscription CreateSubscription(decimal proposedFee, int proposedPeriod);
    }
}
