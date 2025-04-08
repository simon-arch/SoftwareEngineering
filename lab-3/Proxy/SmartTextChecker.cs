namespace Proxy
{
    public class SmartTextChecker : ITextReader
    {
        private readonly ITextReader _reader;

        public SmartTextChecker(ITextReader reader)
        {
            _reader = reader;
        }

        public char[][] Read(string path)
        {
            Console.WriteLine($"[SmartTextChecker] Файл відкрито: {path}");
            var result = _reader.Read(path);
            Console.WriteLine("[SmartTextChecker] Файл прочитано.");
            Console.WriteLine("[SmartTextChecker] Файл закрито.");

            int lines = result.Length;
            int chars = 0;

            foreach (var line in result)
            {
                chars += line.Length;
            }

            Console.WriteLine("[SmartTextChecker] Статистика:");
            Console.WriteLine(new string(' ', 17) + $"> Кількість рядків: {lines}");
            Console.WriteLine(new string(' ', 17) + $"> Кількість символів: {chars}");

            return result;
        }
    }
}
