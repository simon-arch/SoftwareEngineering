namespace CoR.Handlers
{
    class SecuritySupport : BaseHandler
    {
        public override void Handle()
        {
            Console.WriteLine("[Security Support ] Do you have security violation issues?  (y/n)");
            Console.Write("> ");
            string input = Console.ReadLine() ?? "n";

            if (input == "y")
            {
                Console.WriteLine("Security Support called in...");
            }
            else HandleNext();
        }
    }
}
