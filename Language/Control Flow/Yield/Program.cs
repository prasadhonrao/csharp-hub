using System;
using System.Collections.Generic;
using static System.Console;

namespace Learn.CSharp.ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in GetAges())
            {
                WriteLine("Age {0}", item);
            }

            ReadLine();
        }

        public static IEnumerable<int> GetAges()
        {
            yield return 10;
            yield return 20;

            for (int i = 0; i < 10; i++)
            {
                yield return i;
            }

            yield return 30;
            yield break;
            yield return 50; // this stmt will never execute
        }
    }
}
