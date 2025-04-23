namespace Composite.Observer
{
    public class FocusObserver : IEventListener
    {
        public void Update(string type)
        {
            if (type == "focus")
            {
                Console.WriteLine("[focus] Event invoked.");
            }
        }
    }
}
