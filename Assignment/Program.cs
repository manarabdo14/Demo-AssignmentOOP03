using System.Diagnostics;
using System.Reflection.Emit;

namespace Assignment
{
    internal class Program
    {
        static Person GetOldestPerson(Person[] persons)
        {
            Person oldest = persons[0];

            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].Age > oldest.Age)
                {
                    oldest = persons[i];
                }
            }

            return oldest;
        }
        static void Main(string[] args)
        {

            #region Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] persons = new Person[3];

            //try
            //{
            //    persons[0] = new Person("Alice", 30);
            //    persons[1] = new Person("Bob", 25);
            //    persons[2] = new Person("Charlie", 40);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine(e.Message);
            //    return;
            //}

            //foreach (var person in persons)
            //{
            //    Console.WriteLine(person);
            //}
            #endregion

            #region 2 Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] persons = new Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    persons[i] = GetPersonDetails();
            //}

            //Person oldestPerson = GetOldestPerson(persons);

            //Console.WriteLine($"The oldest person is {oldestPerson.Name} with {oldestPerson.Age} years.");

            #endregion

            #region Part 03 Design and implement a Class for the employees in a company
            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "Alice", SecurityLevel.DBA, 80000, new HireDate(1, 1, 2020), "F");
            //EmpArr[1] = new Employee(2, "Bob", SecurityLevel.Guest, 30000, new HireDate(15, 5, 2021), "M");
            //EmpArr[2] = new Employee(3, "Charlie", SecurityLevel.SecurityOfficer, 90000, new HireDate(23, 7, 2019), "M");

            //foreach (var emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //}
            #endregion

            #region Sort the employees based on their hire date then Print the sorted array.     While sorting(how many times Boxing and Unboxing process has occurred)

            #endregion
       

        }
    }
}
