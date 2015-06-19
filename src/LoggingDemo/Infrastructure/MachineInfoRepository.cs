using System;
using LoggingDemo.Core.Interfaces;
using LoggingDemo.Core.Model;

namespace LoggingDemo.Infrastructure
{
    public class MachineInfoRepository : IMachineInfoRepository
    {
        public MachineInfo Get()
        {
            return new MachineInfo(Environment.MachineName);
        }
    }
}