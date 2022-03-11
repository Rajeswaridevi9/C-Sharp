using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";  
            File.WriteAllText("filename.txt", writeText);  // Create a file

            string readText = File.ReadAllText("filename.txt"); // contents of the file
            Console.WriteLine(readText); 
        }
    }
}