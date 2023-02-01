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
            dog lili = new dog();
            lili.race = "Boldog";
            lili.age = 15;
            lili.color = "Black";
            lili.name = "lili";
            dog lili1 = new dog();
            lili1.race = lili.race;
            lili1.age = 2;
            lili1 = lili;
            Console.WriteLine(lili.color);
        }
    }
}