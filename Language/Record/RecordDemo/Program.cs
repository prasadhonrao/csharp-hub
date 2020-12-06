using System;

namespace RecordDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Record");
            Record1 r1 = new Record1("Prasad", "Honrao");
            Console.WriteLine(r1.ToString());

            Console.WriteLine("*************");

            Console.WriteLine("Class");
            Class1 c1 = new Class1("Bill", "Gates");
            Console.WriteLine(c1.ToString());

            Console.ReadLine();
        }
    }

    public record Record1(string FirstName, string LastName);

    public class Class1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Class1(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
