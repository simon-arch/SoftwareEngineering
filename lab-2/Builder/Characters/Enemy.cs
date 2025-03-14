namespace Builder.Characters
{
    public class Enemy : Character
    {
        private List<string> _badIntents = new List<string>();
        public string AddBadIntent(string badThing)
        {
            _badIntents.Add(badThing);
            return badThing;
        }
        public void DoRandomBadThing()
        {
            if (_badIntents.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(_badIntents.Count);
                string goodDeed = _badIntents[index];
                Console.WriteLine($"Enemy is going to {goodDeed}.");
            }
            else
            {
                Console.WriteLine("No bad deeds planned.");
            }
        }
    }
}
