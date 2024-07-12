using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02C_
{
    internal struct Employee
    {
        #region Attributes
        public int Id;
        public string? Name;
        public decimal salary;


        public int Age { get; set; }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        #endregion

        #region Constructors
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id = {Id}\nName= {Name}\nSalary = {Salary}";
        }
        #endregion
    }
}
