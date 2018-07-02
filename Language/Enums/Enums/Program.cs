using System;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var color = RainbowColor.Red;
            Console.WriteLine(color);

            var emp = new Employee();
            emp.Type = EmployeeType.Permanent;
            Console.WriteLine("Employee is of {0} type", emp.Type);

            Console.ReadLine();
        }
    }
}
