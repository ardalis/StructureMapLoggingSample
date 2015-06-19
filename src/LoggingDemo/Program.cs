using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingDemo.UI;

namespace LoggingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var welcomePage = new WelcomePage();
            welcomePage.Display();

            Console.ReadLine();
        }
    }
}
