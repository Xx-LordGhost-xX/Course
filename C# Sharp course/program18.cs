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
            y = new int[400];
            for (int i = 0; i < 400; i++)
            {
                y[i] = 3;
            }
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
            }
               
            
        }
    }
} 