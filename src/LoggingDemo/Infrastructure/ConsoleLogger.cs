using System;
using LoggingDemo.Core.Interfaces;

namespace LoggingDemo.Infrastructure
{
    public class ConsoleLogger : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}