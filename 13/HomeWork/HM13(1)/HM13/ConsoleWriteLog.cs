using System;

namespace HM13
{
    public class ConsoleWriteLog : ILogWriter
    {
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
           Console.WriteLine($"{DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff")}\t{level}\t{message}");
        }
    }
}
