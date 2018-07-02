using System;
using System.Reflection;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(Program);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Public instance members of Program type");
            Console.ResetColor();

            var publicMembers = type.GetMembers();
            foreach (var item in publicMembers)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("\nAll the members of Program type");

            var allMembers = type.GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var item in allMembers)
            {
                Console.WriteLine(item.Name);
            }


            Console.WriteLine("\nAll the members of Employee type");

            type = typeof(Employee);
            var allMembersOfEmployee = type.GetMembers(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var item in allMembersOfEmployee)
            {
                Console.WriteLine(item.Name);
            }

            Console.Read();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        static Employee()
        {

        }

        public Employee()
        {

        }

        public string GetInfo(int empId)
        {
            return "Prasad Honrao";
        }
    }
}
