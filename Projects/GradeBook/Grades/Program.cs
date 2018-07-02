using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GradeBook book = new GradeBook();
                book.NameChanged += new NameChangedDelegate(OnNameChanged);
                //grades.NameChanged += OnNameChanged; // Another way to bind event

                GetGradeBookName(book);
                AddGrades(book);

                GradeStatistics stats = book.ComputeStatistics();
                WriteResults(stats);
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPS! Exception occurred.");
                Console.WriteLine("Exception Message : " + ex.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine("----------------------");
                Console.WriteLine("Press [Enter] to exit");
                Console.Write("----------------------");
                Console.ResetColor();
                Console.ReadLine();
            }
        }

        private static void WriteResults(GradeStatistics stats)
        {
            Console.WriteLine("Lowest grade : " + stats.LowestGrade);
            Console.WriteLine("Average grade : " + stats.AverageGrade);
            Console.WriteLine("Highest grade : " + stats.HighestGrade);

            Console.WriteLine("Letter grade : " + stats.LetterGrade);
            Console.WriteLine("You are doing : " + stats.Description);
        }

        private static void AddGrades(GradeBook grades)
        {
            grades.Add(50);
            grades.Add(60);
            grades.Add(70);
        }

        private static void GetGradeBookName(GradeBook grades)
        {
            Console.Write("Enter Gradebook name : ");
            grades.Name = Console.ReadLine();
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Gradebook name changing from {0} to {1}", args.ExistingName, args.NewName);
        }
    }
}
