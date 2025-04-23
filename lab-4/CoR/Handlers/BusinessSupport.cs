namespace CoR.Handlers
{
    class BusinessSupport : BaseHandler
    {
        public override void Handle()
        {
            Console.Clear();
            Console.WriteLine("=== Support Ticket ===");
            Console.WriteLine("[Business Support ] Do you have business related questions? (y/n)");
            Console.Write("> ");
            string input = Console.ReadLine() ?? "n";

            if (input == "y")
            {
                Console.WriteLine("Business Support called in...");
            }
            else HandleNext();
        }
    }
}
