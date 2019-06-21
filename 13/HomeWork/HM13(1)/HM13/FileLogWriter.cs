using System;
using System.IO;
using System.Text;

namespace HM13
{
    public class FileLogWriter : ILogWriter
    {
        private readonly string _file;
        public FileLogWriter(string file)
        {
            _file = file;
        }
        public void LogError(string message)
        {
            Body(LogLevel.Error, message);
        }

        public void LogInfo(string message)
        {
            Body(LogLevel.Info, message);
        }

        public void LogWarning(string message)
        {
            Body(LogLevel.Warning, message);
        }
        private void Body(LogLevel level, string message)
        {
            using (var streamWriter = new StreamWriter(_file, true, Encoding.UTF8))
            {
                streamWriter.WriteLine($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff")}\t{level}\t{message}");
            }
        }
    }
}
