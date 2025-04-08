namespace Adapter
{
    public class FileWriter
    {
        public string path = string.Empty;
        public FileWriter(string path)
        {
            this.path = path;
        }

        public void Write(string content)
        {
            using (StreamWriter writetext = new StreamWriter(path, true))
            {
                writetext.Write(content);
            }
        }

        public void WriteLine(string content)
        {
            using (StreamWriter writetext = new StreamWriter(path, true))
            {
                writetext.WriteLine(content);
            }
        }
    }
}