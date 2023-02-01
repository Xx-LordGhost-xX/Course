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
            lili(12, 10);
        }
        public static void lili(int value, int sri)
        {
            value = value + sri;
            Console.WriteLine(value);
        }
    }
}