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
            Console.WriteLine("Enter Number");
            int numberright = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Guess Times");
            int guess = int.Parse(Console.ReadLine());
            Console.Clear();

            int counter = 0;
            while (counter <= guess)
            {
                Console.WriteLine("Try To Guess Number");
                int playerguess = int.Parse(Console.ReadLine());
                if (playerguess == numberright)
                {
                    Console.WriteLine("You Won!");
                    counter = guess;
                }
                else
                {
                    if (playerguess > numberright)
                    {
                        Console.WriteLine("Too Big");
                    }
                    else
                    {
                        Console.WriteLine("Too Small");
                    }
                }
                counter = counter + 1;
            }
        }
    }
}