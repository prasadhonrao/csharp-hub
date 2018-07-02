using System;

namespace Learn.CSharp.Language
{
    class Program
    {
        // Uninitialized enum variable will always point to enum with value 0. 
        // If enums are not defined with value, first item is considered at 0th location.

        static RainbowColors rainbow1;
        static RainbowColors rainbow2 = RainbowColors.Indigo;

        static void Main(string[] args)
        {
            Console.WriteLine(rainbow1);
            Console.WriteLine(rainbow2);
            Console.ReadLine();
        }
    }
}
