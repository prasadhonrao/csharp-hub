using static System.Console;

Console.WriteLine("Do...While Loop!");

Write("Enter a number to calculate factorial : ");
int inputNumber = int.Parse(ReadLine());

WriteLine("{0} factorial is {1}", inputNumber, Factorial(inputNumber));

static double Factorial(int input)
{
    double fact = 1;
    do
    {
        fact = fact * input;
        input--;
    }
    while (input > 0);

    return fact;
}