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
            bool mishtane = (5 == 5);
            if (mishtane)
            {
                Console.WriteLine("Hii");
            }

            bool mishtane1 = (5 == 6);
            if (mishtane1)
            {
                Console.WriteLine("Hii");
            }
        }
    }
}