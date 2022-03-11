using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;
    namespace Sample
    {
        class Demo
        {
#pragma warning disable CS0017 // Program has more than one entry point defined. Compile with /main to specify the type that contains the entry point.
            static void Main(string[] args)
#pragma warning restore CS0017 // Program has more than one entry point defined. Compile with /main to specify the type that contains the entry point.
            {
                int num1 = 50;
                int num2 = 25;
                int result;
                result = num1 + num2;
                Console.WriteLine("Value is {0}", result);
                result = num1 - num2;
                Console.WriteLine("Value is {0}", result);
                result = num1 * num2;
                Console.WriteLine("Value is {0}", result);
                result = num1 / num2;
                Console.WriteLine("Value is {0}", result);
                result = num1 % num2;
                Console.WriteLine("Value is {0}", result);
                result = num1++;
                Console.WriteLine("Value is {0}", result);
                result = num1--;
                Console.WriteLine("Value is {0}", result);
                Console.ReadLine();
            }
        }
    }
}
    