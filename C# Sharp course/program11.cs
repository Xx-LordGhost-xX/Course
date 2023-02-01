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
            string usarname, password;
            Console.WriteLine("Please Enter UserName");
            usarname = Console.ReadLine();
            Console.WriteLine("Please Enter Password");
            password = Console.ReadLine();
            if (usarname=="Asaf"||password=="1234"&& usarname=="efi")
            {
                Console.WriteLine("Logged In");
            }
            else
            {
                Console.WriteLine("Wrong Info");
            }
        }
    }
}