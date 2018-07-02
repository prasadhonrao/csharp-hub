using System;

namespace Learn.CSharp.Language
{
    public delegate void Print<T>(T item);

    class Program
    {
        static void Main(string[] args)
        {
            var intPrint = new Print<int>(PrintInts);
            var stringPrint = new Print<string>(PrintStrings);

            intPrint(10);
            stringPrint("Priting using generic custom delegate");

            Console.ReadLine();
        }

        static void PrintInts(int item)
        {
            Console.WriteLine(item);
        }

        static void PrintStrings(string item)
        {
            Console.WriteLine(item);
        }
    }
}
