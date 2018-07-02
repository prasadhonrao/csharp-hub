using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ConcurrentQueue.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Single Threaded Queue

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("*** Single Threaded Queue ***");
            //Console.ResetColor();

            //var orders = new Queue<string>();
            //PlaceOrder(orders, "Mark");
            //PlaceOrder(orders, "Steve");
            //PlaceOrder(orders, "Adam");

            //foreach (var order in orders)
            //{
            //    Console.WriteLine("ORDER : " + order);
            //}

            #endregion

            #region Multi Threaded Queue

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("*** Multi Threaded Queue  ***");
            //Console.ResetColor();

            //var orders2 = new Queue<string>();

            //// BEWARE OF DATA LOSS SINCE QUEUE CLASS IS BEST SUITED FOR SINGLE THREDED ENVIRONMENT

            //Task task1 = Task.Run(() => PlaceOrder(orders2, "Mark"));
            //Task task2 = Task.Run(() => PlaceOrder(orders2, "Steve"));
            //Task task3 = Task.Run(() => PlaceOrder(orders2, "Adam"));
            //Task.WaitAll(task1, task2, task3);

            //foreach (var order in orders2)
            //{
            //    Console.WriteLine("ORDER : " + order);
            //}

            #endregion

            #region Multi Threaded Queue with lock

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("*** Multi Threaded Queue with lock  ***");
            //Console.ResetColor();

            //var orders2 = new Queue<string>();
            //Task task1 = Task.Run(() => PlaceOrderWithLock(orders2, "Mark"));
            //Task task2 = Task.Run(() => PlaceOrderWithLock(orders2, "Steve"));
            //Task task3 = Task.Run(() => PlaceOrderWithLock(orders2, "Adam"));
            //Task.WaitAll(task1, task2, task3);

            //foreach (var order in orders2)
            //{
            //    Console.WriteLine("ORDER : " + order);
            //}

            #endregion

            #region Single Threaded Concurrent Queue

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("*** Single Threaded Concurrent Queue  ***");
            //Console.ResetColor();

            //var concurrentOrders = new ConcurrentQueue<string>();
            //PlaceOrder(concurrentOrders, "Mark");
            //PlaceOrder(concurrentOrders, "Steve");
            //PlaceOrder(concurrentOrders, "Adam");

            //foreach (var order in concurrentOrders)
            //{
            //    Console.WriteLine("Concurrent Order : " + order);
            //}

            #endregion

            #region Multithreaded Concurrent Queue

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("*** Multithreaded Concurrent Queue  ***");
            //Console.ResetColor();

            //var concurrentOrders = new ConcurrentQueue<string>();

            //// UNEXPECTED RESULTS (SEQUENCE) IF RUN ON MULTIPLE THREADS
            //Task task1 = Task.Run(() => PlaceOrder(concurrentOrders, "Mark"));
            //Task task2 = Task.Run(() => PlaceOrder(concurrentOrders, "Steve"));
            //Task task3 = Task.Run(() => PlaceOrder(concurrentOrders, "Adam"));
            //Task.WaitAll(task1, task2, task3);

            //foreach (var order in concurrentOrders)
            //{
            //    Console.WriteLine("Concurrent Order : " + order);
            //}

            #endregion

            Console.ReadLine();
        }

        static void PlaceOrder(Queue<string> orders, string name)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1);
                var orderName = string.Format("{0} wants T-Shirt {1}", name, i);
                orders.Enqueue(orderName);
            }
        }

        static object _lock = new object();
        static void PlaceOrderWithLock(Queue<string> orders, string name)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1);
                var orderName = string.Format("{0} wants T-Shirt {1}", name, i);
                // WHEN LOCK IS USED, EVEN IF YOU HAVE MULTIPLE THREADS, ONLY ONE THREAD CAN ACCESS THE QUEUE AT A TIME WHICH IS NOT EFFICIENT
                lock (_lock)
                {
                    orders.Enqueue(orderName);
                }
            }
        }

        static void PlaceOrder(ConcurrentQueue<string> orders, string name)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1);
                var orderName = string.Format("{0} wants T-Shirt {1}", name, i);
                orders.Enqueue(orderName);
            }
        }
    }
}
