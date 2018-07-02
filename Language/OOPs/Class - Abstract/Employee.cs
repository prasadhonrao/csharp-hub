namespace Learn.CSharp.Language
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual int CalculateSalary(int noOfDays)
        {
            return noOfDays * 100;
        }
    }

    public class ContactorEmployee : Employee
    {
        public override int CalculateSalary(int noOfDays)
        {
            return noOfDays * 200;
        }
    }

    public class PermanentEmployee : Employee
    {
        public override int CalculateSalary(int noOfDays)
        {
            return base.CalculateSalary(noOfDays);
        }
    }

    public class TemporaryEmployee : Employee
    {
        // since we did not override, it will by default call base class function
    }
}
