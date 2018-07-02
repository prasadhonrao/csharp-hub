using System;
using static System.Console;

namespace Learn.CSharp.ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentMonth = DateTime.Now.Month;
            switch (currentMonth)
            {
                case 1:
                case 2:
                case 3:
                    WriteLine("Current month is in Q1");
                    break;
                case 4:
                case 5:
                case 6:
                    WriteLine("Current month is in Q2");
                    break;
                case 7:
                case 8:
                case 9:
                    WriteLine("Current month is in Q3");
                    break;
                default:
                    WriteLine("Current month is in Q4");
                    break;
            }

            WriteLine("---------------------------");
            WriteLine("Press [Enter] key to exit");
            WriteLine("---------------------------");
            ReadLine();
        }
    }
}
