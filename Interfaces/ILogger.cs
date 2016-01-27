namespace MyLogger.Interfaces
{
    public interface ILogger
    {
        IAppender Appender { get; set; }

        void Info(string message);

        void Warn(string message);

        void Error(string message);

        void Critical(string message);

        void Fatal(string message);
    }
}
