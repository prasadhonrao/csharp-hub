using static System.Console;
Console.WriteLine("For Loop!");

Write("Enter number to calculate factorial : ");
int inputNumber = int.Parse(ReadLine());

WriteLine("{0} factorial is {1}", inputNumber, Factorial(inputNumber));

static double Factorial(int input)
{
    double fact = 1;

    for (double ctr = 1; ctr <= input; ctr++)
    {
        fact = fact * ctr;
    }

    return fact;
}