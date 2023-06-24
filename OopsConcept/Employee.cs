using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    // Class definition
    public class Employee
    {
        // Private fields encapsulated through properties
        private string name;
        private int age;
        private double salary;

        // Public properties for accessing and setting private fields
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Method to display employee details
        public void DisplayInfo()
        {
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Age: " + age);
            Console.WriteLine("Employee Salary: " + salary);
        }
    }

    public class EncapusulationDemo
    {
        public static void EncapsulationDemoMethod()
        {
            // Create an object of the Employee class
            Employee emp = new Employee();

            // Set employee details using properties
            emp.Name = "John Doe";
            emp.Age = 30;
            emp.Salary = 5000.50;

            // Access and display employee details using properties and methods
            emp.DisplayInfo();
        }
    }
}
