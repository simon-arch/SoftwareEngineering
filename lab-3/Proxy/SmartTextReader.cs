namespace Proxy
{
    public class SmartTextReader : ITextReader
    {
        public char[][] Read(string path)
        {
            Console.WriteLine("[SmartTextReader ] Обробка тексту.");
            string[] lines = File.ReadAllLines(path);
            char[][] result = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray();
            }

            return result;
        }
    }
}
