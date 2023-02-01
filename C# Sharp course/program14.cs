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
            int number;
            while (x < 20)
            {
                number = int.Parse(Console.ReadLine());
                if (number > 100)
                {
                    Console.WriteLine("Bigger");
                }
                else
                {
                    Console.WriteLine("Smaller");
                }
            } 
        }
    }
}