namespace Learn.CSharp.Language
{
    public abstract class People
    {
        public int Id { get; set; }
    }

    public sealed class Employee : People
    {
        public string Name { get; set; }
    }

    // Cannot derive from Employee

    //public class Contractor : Employee
    //{
    //}
}
