using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingDemo.Core.Interfaces;
using LoggingDemo.Infrastructure;
using LoggingDemo.UI;
using StructureMap;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace LoggingDemo
{
    class Program
    {
        private Container _container;

        public Program(Container container)
        {
            _container = container;
        }

        static void Main(string[] args)
        {
            var program = new Program( new Container(new ProgramRegistry()));
            program.Run();

            Console.ReadLine();
        }

        private void Run()
        {
            var welcomePage = _container.GetInstance<WelcomePage>();
            welcomePage.Display();
        }

        private class ProgramRegistry : Registry
        {
            public ProgramRegistry()
            {
                Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });

                // no longer used, but kept as a default
                For<ILog>().Use(() => new ConsoleLogger("All"));

                // shown for clarity; can be removed since WithDefaultConventions() is used
                For<IDataLogger>().Use<DataLogger>();
                For<IUILogger>().Use<UILogger>();
            }
        }
    }
}
