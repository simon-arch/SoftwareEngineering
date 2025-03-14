class Program
{
    public sealed class Authenticator
    {
        private static Authenticator instance = null;
        private static readonly object _lock = new object();

        Authenticator() { }

        public static Authenticator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                    {
                        if (instance == null)
                        {
                            instance = new Authenticator();
                        }
                    }
                }
                return instance;
            }
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(() =>
        {
            Authenticator instance1 = Authenticator.Instance;
            Console.WriteLine($"t1. Authenticator Instance I Hash: {instance1.GetHashCode()}");
        });
        Thread t2 = new Thread(() =>
        {
            Authenticator instance2 = Authenticator.Instance;
            Console.WriteLine($"t2. Authenticator Instance II Hash: {instance2.GetHashCode()}");
        });
        Thread t3 = new Thread(() =>
        {
            Authenticator instance3 = Authenticator.Instance;
            Console.WriteLine($"t3. Authenticator Instance III Hash: {instance3.GetHashCode()}");
        });

        t1.Start();
        t2.Start();
        t3.Start();

        Console.ReadLine();
    }
}
