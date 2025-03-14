namespace Builder.Characters
{
    public class Hero : Character
    {
        private List<string> _goodIntents = new List<string>();
        public string AddGoodIntent(string goodThing)
        {
            _goodIntents.Add(goodThing);
            return goodThing;
        }
        public void DoRandomGoodThing()
        {
            if (_goodIntents.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(_goodIntents.Count);
                string goodDeed = _goodIntents[index];
                Console.WriteLine($"Hero is going to {goodDeed}.");
            }
            else
            {
                Console.WriteLine("No good deeds planned.");
            }
        }
    }
}
