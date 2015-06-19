using System;
using LoggingDemo.Core.Interfaces;
using LoggingDemo.Core.Model;

namespace LoggingDemo.Infrastructure
{
    public class MachineInfoRepository : IMachineInfoRepository
    {
        private readonly IDataLogger _logger;

        public MachineInfoRepository(IDataLogger logger)
        {
            _logger = logger;
        }

        public MachineInfo Get()
        {
            _logger.Log("Getting MachineInfo");
            return new MachineInfo(Environment.MachineName);
        }
    }
}