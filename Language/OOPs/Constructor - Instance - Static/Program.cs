using System;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();

            Console.ReadLine();
        }
    }

    public class Employee
    {
        static Employee()
        {
            Console.WriteLine("Static constructor was called!");
        }

        public Employee()
        {
            Console.WriteLine("Instance constructor was called!");
        }
    }
}
