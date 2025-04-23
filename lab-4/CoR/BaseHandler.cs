namespace CoR
{
    abstract class BaseHandler
    {
        private BaseHandler? _next;

        public BaseHandler SetNextHandler(BaseHandler next)
        {
            _next = next;
            return next;
        }

        public abstract void Handle();

        protected void HandleNext()
        {
            if (_next == null)
            {
                Console.WriteLine("Default Handler Implementation");
            }
            else
            {
                _next.Handle();
            }
        }
    }
}
