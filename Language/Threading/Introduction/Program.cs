using System;
using System.Threading;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Basic information retrieved from current thread \n");

            Console.WriteLine("Current Thread Id is {0} ", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Current Culture is {0}", Thread.CurrentThread.CurrentCulture);
            Console.WriteLine("Current UI Culture is {0}", Thread.CurrentThread.CurrentUICulture.DisplayName);
            Console.WriteLine("Current thread is background thread? {0}", Thread.CurrentThread.IsBackground);

            Console.ReadLine();
        }
    }
}
