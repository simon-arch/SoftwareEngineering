namespace Composite.Observer
{
    public class ClickObserver : IEventListener
    {
        public void Update(string type)
        {
            if (type == "click")
            {
                Console.WriteLine("[click] Event invoked.");
            }
        }
    }
}
