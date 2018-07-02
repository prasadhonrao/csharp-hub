using System;
namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 100;

            object age = counter; // boxing

            DisplayValue(counter); // boxing

            Console.ReadLine();
        }

        public static void DisplayValue(object value)
        {
            int local = (int)value; //unboxing
        }
    }
}
