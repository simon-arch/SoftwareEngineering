namespace CoR.Handlers
{
    class CustomerSupport : BaseHandler
    {
        public override void Handle()
        {
            Console.WriteLine("[Customer Support ] Do you have customer related questions? (y/n)");
            Console.Write("> ");
            string input = Console.ReadLine() ?? "n";

            if (input == "y")
            {
                Console.WriteLine("Customer Support called in...");
            }
            else HandleNext();
        }
    }
}
