namespace Adapter
{
    public class FileLogger : Logger
    {
        private readonly FileWriter _fileWriter;

        public FileLogger(string path)
        {
            _fileWriter = new FileWriter(path);
        }

        public override void Log(string message)
        {
            _fileWriter.WriteLine($"{DateTime.Now:[yyyy-MM-dd][HH:mm:ss]} <Log> {message}");
        }

        public override void Warn(string message)
        {
            _fileWriter.WriteLine($"{DateTime.Now:[yyyy-MM-dd][HH:mm:ss]} <Warn> {message}");
        }

        public override void Error(string message)
        {
            _fileWriter.WriteLine($"{DateTime.Now:[yyyy-MM-dd][HH:mm:ss]} <Error> {message}");
        }
    }
}