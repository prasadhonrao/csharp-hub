using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.Write("What's your name : ");
            var userName = Console.ReadLine();
            Console.WriteLine("Welcome to C# programming " + userName);

            Console.WriteLine("-----------------------");
            Console.WriteLine("Press [Enter] to exit");
            Console.ReadLine();
        }
    }
}
