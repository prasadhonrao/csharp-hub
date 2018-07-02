namespace Learn.CSharp.Language
{
    public class Company
    {
        private readonly Employee[] _employees = { new Employee("Amit"), new Employee("Prasad") };

        public Employee this[int index]
        {
            get
            {
                return _employees[index];
            }
            set
            {
                _employees[index] = value;
            }

        }
    }
}
