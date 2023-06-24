using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    //Create a program to demonstrate types of variables present in c#.
    public class DataType
    {
       public static void DataTypeMethod()
        {
            // Integer variable
            int age = 30;
            Console.WriteLine("Age: " + age);

            // Floating-point variable
            double salary = 5000.50;
            Console.WriteLine("Salary: " + salary);

            // Character variable
            char gender = 'M';
            Console.WriteLine("Gender: " + gender);

            // Boolean variable
            bool isStudent = true;
            Console.WriteLine("Is Student: " + isStudent);

            // String variable
            string name = "John Doe";
            Console.WriteLine("Name: " + name);

            // Array variable
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.Write("Numbers: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Object variable
            object obj = 42;
            Console.WriteLine("Object: " + obj);

            // Nullable variable
            int? nullableNumber = null;
            Console.WriteLine("Nullable Number: " + nullableNumber);

            // Enum variable
            DayOfWeek day = DayOfWeek.Monday;
            Console.WriteLine("Day: " + day);
        }
    }
}
