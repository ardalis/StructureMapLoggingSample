namespace LoggingDemo.Core.Interfaces
{
    public interface ILog
    {
        void Log(string message);
    }

    public interface IDataLogger : ILog
    {
    }

    public interface IUILogger : ILog
    {
    }
}
