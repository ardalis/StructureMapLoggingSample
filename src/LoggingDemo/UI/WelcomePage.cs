using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingDemo.Core.Interfaces;

namespace LoggingDemo.UI
{
    public class WelcomePage
    {
        private readonly ILog _logger;
        private readonly IMachineInfoRepository _machineInfoRepository;

        public WelcomePage(ILog logger, IMachineInfoRepository machineInfoRepository)
        {
            _logger = logger;
            _machineInfoRepository = machineInfoRepository;
        }

        public void Display()
        {
            Console.WriteLine("Hello World From {0}", System.Environment.MachineName);
        }
    }
}
