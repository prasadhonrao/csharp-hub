using System;
using static System.Console;

namespace Learn.CSharp.ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your name : ");
            string userName = ReadLine();

            #region if - else

            if (DateTime.Now.Hour >= 8 && DateTime.Now.Hour < 12)
            {
                WriteLine("Good morning {0}", userName);
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 17)
            {
                WriteLine("Good afternoon {0}", userName);
            }
            else
            {
                WriteLine("{0}, you're working odd hours", userName);
            }
            
            #endregion

            #region turnary operator ?

            var is64BitOs = Environment.Is64BitOperatingSystem ? "Yes" : "No";
            WriteLine("Is 64 bit operating system : {0}", is64BitOs); 
            
            #endregion

            ReadLine();
        }
    }
}
