using System;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main()
        {
            var company = new Company();
            var emp = company[0];
            Console.WriteLine(emp.Name);
            Console.ReadLine();
        }
    }
}
