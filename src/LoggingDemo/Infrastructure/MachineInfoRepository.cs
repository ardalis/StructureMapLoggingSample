using System;
using LoggingDemo.Core.Interfaces;
using LoggingDemo.Core.Model;

namespace LoggingDemo.Infrastructure
{
    public class MachineInfoRepository : IMachineInfoRepository
    {
        private readonly ILog _logger;

        public MachineInfoRepository(ILog logger)
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