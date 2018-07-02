using System;

namespace Learn.CSharp.Language
{
    class Program
    {
        static void Main(string[] args)
        {
            var newEmployee = new Employee();
            newEmployee.ID = 101;
            newEmployee.FirstName = "Prasad";
            newEmployee.LastName = "Honrao";

            Console.WriteLine(newEmployee.FullName);
            Console.WriteLine(newEmployee.ToString());
            Console.ReadLine();
        }
    }

    public class Employee
    {
        #region Fields

        public string FullName => FirstName + " " + LastName;

        private string _lastName;

        #endregion

        #region Properties

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value != string.Empty)
                    _lastName = value;
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return ID + " " + FullName;
        }

        #endregion
    }
}
