using System.Text;

namespace Factory.Subscriptions
{
    public abstract class Subscription
    {
        public decimal MonthlyFee { get; set; }
        public int MinimumSubscriptionPeriod { get; set; }
        public List<string> Channels { get; set; }
        public List<string> Features { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"┌ Selected: {GetType().Name}");
            sb.AppendLine($"│      Fee: ${MonthlyFee}");
            sb.AppendLine($"└   Period: {MinimumSubscriptionPeriod} month(s)");
            return sb.ToString();
        }
    }
}
