using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace.");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentException("Age must be between 0 and 120.");
                }
                age = value;
            }
        }

        public Person(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.");
            }
            if (age < 0 || age > 120)
            {
                throw new ArgumentException("Age must be between 0 and 120.");
            }

            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
