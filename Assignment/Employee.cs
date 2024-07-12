using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Employee
    {
        private string _gender;
        private decimal _salary;

        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary cannot be negative");
                _salary = value;
            }
        }
        public HireDate HireDate { get; set; }
        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value != "M" && value != "F")
                    throw new ArgumentException("Gender must be either 'M' or 'F'");
                _gender = value;
            }
        }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HireDate hireDate, string gender)
        {
            ID = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary.ToString("C", CultureInfo.CurrentCulture)}, Hire Date: {HireDate}, Gender: {Gender}";
        }
    }
}
