using System;
using System.Threading;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting Main thread with Id {0}", Thread.CurrentThread.ManagedThreadId);

            var PlusThread = new Thread(PrintPlus);
            var MinusThread = new Thread(PrintMinus);

            PlusThread.Start();
            MinusThread.Start();

            Console.WriteLine("Ending Main thread with Id {0}", Thread.CurrentThread.ManagedThreadId);

            Console.ReadLine();
        }

        static void PrintMinus()
        {
            // Console.WriteLine("Thread id is {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 100; i++)
            {
                Console.Write(" + ");
            }

        }

        static void PrintPlus()
        {
            // Console.WriteLine("Thread id is {0}", Thread.CurrentThread.ManagedThreadId);

            for (int i = 0; i < 100; i++)
            {
                Console.Write(" - ");
            }
        }
    }
}
