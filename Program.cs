using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Select Module to run");
                Console.WriteLine("1. Hello World");
                Console.WriteLine("Press Escape to Exit");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
