using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            Type empType = typeof(Employee);

            PropertyInfo[] properties = empType.GetProperties();

            foreach (var property in properties)
            {
                Console.WriteLine("Getting attribute for {0}", property.Name);
                var attributes = property.GetCustomAttributes();
                foreach (var item in attributes)
                {
                    Console.WriteLine(item.GetType().Name);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(20, 60)]
        [Required]
        public int Age { get; set; }
    }
}
