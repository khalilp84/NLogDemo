using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.TestNLog();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
