namespace Mediator
{
    public class Aircraft : BaseComponent
    {
        public string Name { get; set; }
        public Aircraft(string name)
        {
            Name = name;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {Name} requests landing.");
            _mediator?.OnTryLand(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {Name} requests takeoff.");
            _mediator?.OnTryTakeOff(this);
        }
    }
}
