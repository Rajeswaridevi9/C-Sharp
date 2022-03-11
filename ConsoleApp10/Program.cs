using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp10
{
    class Welcome
    {
        // Default constructor
        public Welcome()
        {
            Console.WriteLine("Welcome message from Default Constructor...");
        }

        // Parametarized constructor
        public Welcome(string name)
        {
            Console.WriteLine("\n\nThis message from parametarized constructor");
            Console.WriteLine("Welcome to Constructor sample, by {0}", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Welcome obj = new Welcome();

            
            Welcome pObj = new Welcome("Ramakrishna ");

            Console.Read();
        }
    }
}
