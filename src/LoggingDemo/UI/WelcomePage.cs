using System;
using LoggingDemo.Core.Interfaces;

namespace LoggingDemo.UI
{
    public class WelcomePage
    {
        private readonly IUILogger _logger;
        private readonly IMachineInfoRepository _machineInfoRepository;

        public WelcomePage(IUILogger logger, IMachineInfoRepository machineInfoRepository)
        {
            _logger = logger;
            _machineInfoRepository = machineInfoRepository;
            _logger.Log("WelcomePage created.");
        }

        public void Display()
        {
            var machineInfo = _machineInfoRepository.Get();
            Console.WriteLine("Hello World From {0}", machineInfo.Name);
        }
    }
}
