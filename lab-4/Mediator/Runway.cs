namespace Mediator
{
    public class Runway : BaseComponent
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusy { get; set; } = false;

        public void SetBusy()
        {
            IsBusy = true;
            HighLightRed();
        }

        public void SetFree()
        {
            IsBusy = false;
            HighLightGreen();
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is free!");
        }
    }
}
