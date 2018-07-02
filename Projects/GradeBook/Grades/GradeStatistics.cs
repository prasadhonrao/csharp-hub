namespace Grades
{
    public class GradeStatistics
    {
        public float HighestGrade;
        public float AverageGrade;
        public float LowestGrade;

        public string LetterGrade
        {
            get
            {
                string result = string.Empty;
                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        public string Description
        {
            get
            {
                string result = string.Empty;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Very Good";
                        break;
                    case "C":
                        result = "Good";
                        break;
                    case "D":
                        result = "Average";
                        break;
                    default:
                        result = "Fail";
                        break;
                }
                return result;
            }
        }
        public GradeStatistics()
        {
            HighestGrade = float.MinValue;
            LowestGrade = float.MaxValue;
        }
    }
}