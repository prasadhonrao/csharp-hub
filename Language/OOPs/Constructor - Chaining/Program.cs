using System;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var pemp = new PermanentEmployee("Prasad Honrao");
            var temp = new TemporaryEmployee("Colin Gray");
            Console.ReadLine();
        }
    }

    class Employee
    {
        public Employee(string baseMessage)
        {
            Console.WriteLine("Creating new employee {0}", baseMessage);
        }
    }

    class PermanentEmployee : Employee
    {
        public PermanentEmployee(string name)
            : base(name)
        {
            Console.WriteLine("New permanent employee {0} created.", name);
        }
    }

    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(string name)
            : base(name)
        {
            Console.WriteLine("New temporary employee {0} created.", name);
        }
    }
}
