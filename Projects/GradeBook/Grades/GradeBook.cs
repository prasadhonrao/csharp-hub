using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        List<float> grades;
        private string name;
        public event NameChangedDelegate NameChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Name cannot be null or empty");

                if (name != value)
                {
                    var nameChangedArgs = new NameChangedEventArgs { ExistingName = name, NewName = value };
                    NameChanged?.Invoke(this, nameChangedArgs); // check for nullness as unit test dont have delegate reference
                }
                name = value;
            }
        }

        public GradeBook()
        {
            this.name = string.Empty;
            this.grades = new List<float>();
        }

        public void Add(float grade)
        {
            this.grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            if (grades.Count == 0)
                throw new ApplicationException("No grades are available to compute statistics");

            var stats = new GradeStatistics();
            float sum = 0;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum = sum + grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
    }
}