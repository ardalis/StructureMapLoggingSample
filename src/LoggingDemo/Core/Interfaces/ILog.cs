using LoggingDemo.Core.Model;

namespace LoggingDemo.Core.Interfaces
{
    public interface ILog
    {
        void Log(string message);
    }

    public interface IOutputWriter
    {
        void WriteLine();
    }

    public interface IMachineInfoRepository
    {
        MachineInfo Get();
    }
}
