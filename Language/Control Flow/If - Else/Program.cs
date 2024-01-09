using static System.Console;

Console.WriteLine("If-Else Statement!");

Write("Enter your name : ");
string userName = ReadLine();

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