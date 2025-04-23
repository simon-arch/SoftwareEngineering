namespace CoR.Handlers
{
    class TechnicalSupport : BaseHandler
    {
        public override void Handle()
        {
            Console.WriteLine("[Technical Support] Do you have any technical issues?       (y/n)");
            Console.Write("> ");
            string input = Console.ReadLine() ?? "n";

            if (input == "y")
            {
                Console.WriteLine("Technical Support called in...");
            }
            else HandleNext();
        }
    }
}
