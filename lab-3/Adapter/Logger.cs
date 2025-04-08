namespace Adapter
{
    public class Logger
    {
        public virtual void Log(string message) => Output(ConsoleColor.Green, "Log", message);
        public virtual void Warn(string message) => Output(ConsoleColor.Yellow, "Warn", message);
        public virtual void Error(string message) => Output(ConsoleColor.Red, "Error", message);
        private void Output(ConsoleColor color, string level, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{DateTime.Now:[yyyy-MM-dd][HH:mm:ss]} <{level}> {message}");
            Console.ResetColor();
        }
    }
}
