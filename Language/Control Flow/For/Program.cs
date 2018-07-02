using static System.Console;

namespace Learn.CSharp.ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter number to calculate factorial : ");
            int inputNumber = int.Parse(ReadLine());

            WriteLine("{0} factorial is {1}", inputNumber, Factorial(inputNumber));
            ReadLine();
        }

        public static double Factorial(int input)
        {
            double fact = 1;

            for (double ctr = 1; ctr <= input; ctr++)
            {
                fact = fact * ctr;
            }

            return fact;
        }
    }
}
