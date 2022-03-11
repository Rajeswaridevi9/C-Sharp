using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
     abstract class Language
        {

            // non-abstract method
            public void display()
            {
                Console.WriteLine("Non abstract method");
            }
        }

        // inheriting from abstract class
        class Program_10 : Language
        {

            static void Main(string[] args)
            {

                
                Program_10 obj = new Program_10();

                
                obj.display();

                Console.ReadLine();
            }
        }
    }

