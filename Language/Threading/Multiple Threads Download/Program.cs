using System;
using System.Diagnostics;
using System.Net;
using System.Threading;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Download using single thread - asynchronous operation");

            DownloadInformationUsingMultipleThreads();

            Console.WriteLine("Main thread id is {0}", Thread.CurrentThread.ManagedThreadId);

            Console.Read();
        }

        private static void DownloadInformationUsingMultipleThreads()
        {
            var watch = new Stopwatch();
            watch.Start();

            string[] urls = {
                                "http://www.Microsoft.com",
                                "http://www.Apple.com",
                                "http://www.Google.com"
                            };

            foreach (var url in urls)
            {
                // Asynchronous operation using Thread
                var childThread = new Thread(DownloadContent);
                childThread.Start(url);
            }

            watch.Stop();
            Console.WriteLine("Execution Time {0} ms", watch.ElapsedMilliseconds);
        }

        private static void DownloadContent(object url)
        {
            var client = new WebClient();
            var result = client.DownloadString(url.ToString());
            Console.WriteLine("Downloading {0} chars for {1} using thread {2}", result.Length, url.ToString(), Thread.CurrentThread.ManagedThreadId);
        }
    }
}
