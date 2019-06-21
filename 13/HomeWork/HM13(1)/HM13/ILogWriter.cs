namespace HM13
{
    public interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
