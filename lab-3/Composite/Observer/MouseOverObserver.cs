namespace Composite.Observer
{
    public class MouseOverObserver : IEventListener
    {
        public void Update(string type)
        {
            if (type == "mouseover")
            {
                Console.WriteLine("[mouseover] Event invoked.");
            }
        }
    }
}
