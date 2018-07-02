using System;
using System.Threading;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Starting Main thread with Id {0}", Thread.CurrentThread.ManagedThreadId);

            Thread T = new Thread(PrintHelloWorld);
            T.Name = "Hello World Thread";
            T.Priority = ThreadPriority.Highest; // Helps OS to schedule the thread based on its priority
            T.Start();

            Console.WriteLine("Ending Main thread with Id {0}", Thread.CurrentThread.ManagedThreadId);

            Console.Read();
        }

        private static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Thread id is {0}", Thread.CurrentThread.ManagedThreadId);
        }
    }
}
