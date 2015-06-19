using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingDemo.UI
{
    public class WelcomePage
    {
        public void Display()
        {
            Console.WriteLine("Hello World From {0}", System.Environment.MachineName);
        }
    }
}
