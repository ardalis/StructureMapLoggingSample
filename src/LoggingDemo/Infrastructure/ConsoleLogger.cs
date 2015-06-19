using System;
using LoggingDemo.Core.Interfaces;

namespace LoggingDemo.Infrastructure
{
    public class ConsoleLogger : ILog
    {
        private readonly string _loggerLevel;

        public ConsoleLogger(string loggerLevel)
        {
            _loggerLevel = loggerLevel;
        }

        public void Log(string message)
        {
            Console.WriteLine("[{0}] {1}", _loggerLevel, message);
        }
    }

    public class UILogger : ConsoleLogger, IUILogger
    {
        public UILogger() : base("UI")
        {
        }
    }

    public class DataLogger : ConsoleLogger, IDataLogger
    {
        public DataLogger() : base("Data")
        {
        }
    }
}