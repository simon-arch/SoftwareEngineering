using System.Text.RegularExpressions;

namespace Proxy
{
    public class SmartTextReaderLocker : ITextReader
    {
        private readonly ITextReader _reader;
        private readonly Regex _regex;

        public SmartTextReaderLocker(ITextReader reader, string pattern)
        {
            _reader = reader;
            _regex = new Regex(pattern, RegexOptions.IgnoreCase);
        }

        public char[][] Read(string path)
        {
            Console.WriteLine("[SmartTextReaderLocker] Перевірка доступу.");
            if (_regex.IsMatch(path))
            {
                Console.WriteLine("[SmartTextReaderLocker] Access denied!");
                return Array.Empty<char[]>();
            }
            return _reader.Read(path);
        }
    }
}
