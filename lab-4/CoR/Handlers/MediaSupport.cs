namespace CoR.Handlers
{
    class MediaSupport : BaseHandler
    {
        public override void Handle()
        {
            Console.WriteLine("[Media Support    ] Do you have media related suggestions?  (y/n)");
            Console.Write("> ");
            string input = Console.ReadLine() ?? "n";

            if (input == "y")
            {
                Console.WriteLine("Media Support called in...");
            }
            else HandleNext();
        }
    }
}
