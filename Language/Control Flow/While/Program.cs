using static System.Console;

Console.WriteLine("While Loop!");

Write("Enter a number to calculate factorial : ");
int inputNumber = int.Parse(ReadLine());

WriteLine("{0} factorial is {1}", inputNumber, Factorial(inputNumber));

static double Factorial(int input)
{
    double fact = 1;

    while (input > 0)
    {
        fact = fact * input;
        input--;
    }

    return fact;
}