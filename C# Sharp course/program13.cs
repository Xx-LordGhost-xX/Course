using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x > 10)
            {
                Console.WriteLine("Smaller");
                x = x + 1;
            } 
        }
    }
}