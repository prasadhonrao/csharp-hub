using System;

namespace Learn.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork("Coding");
            DoWork(null);

            Console.ReadLine();
        }

        static void DoWork(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            else
            {
                Console.WriteLine("Doing work " + name);
            }
        }
    }
}
