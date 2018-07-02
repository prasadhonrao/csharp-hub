using System.Linq;
using static System.Console;

namespace Learn.CSharp.ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70 }; 

            var numbers = Enumerable.Range(1, 100);

            foreach (var number in numbers)
            {
                if (number == 30)
                {
                    WriteLine("Continue" + number);
                    continue;
                }

                if (number == 60)
                {
                    WriteLine("Break" + number);
                    break;
                }

                WriteLine(number);
            }

            ReadLine();
        }
    }
}
