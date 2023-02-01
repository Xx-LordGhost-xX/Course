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
            int[] y;
            y = new int[200];
            for (int i = 0; i < 200; i++)
            {
                y[i] = 1;
                Console.WriteLine(y[i]);
            }     
        }
    }
} 