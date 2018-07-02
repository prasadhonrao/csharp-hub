using System.Collections.Generic;
using System.Diagnostics;
using static System.Console;

namespace Learn.CSharp.ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Iterating over string array

            WriteLine("Iterating over string array...");

            string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Voilet" };

            foreach (var color in colors)
            {
                WriteLine(color);
            }

            WriteLine();

            #endregion

            #region Iterating over generic string list"

            WriteLine("Iterating over generic string list");

            List<string> rainbow = new List<string>() { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Voilet" };

            foreach (var color in rainbow)
            {
                WriteLine(color);
            }

            WriteLine();

            #endregion

            #region Iterating over generic object list

            WriteLine("Iterating over generic object list");

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Name = "Prasad" });
            employees.Add(new Employee() { Name = "Amit" });
            employees.Add(new Employee() { Name = "Colin" });

            foreach (var item in employees)
            {
                WriteLine(item.Name);
            }

            WriteLine();

            #endregion

            #region Iterating over processes list

            WriteLine("Iterating over processes list");

            Process[] processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                WriteLine(process.ProcessName);
            }

            WriteLine();

            #endregion

            ReadLine();
        }
    }
}
