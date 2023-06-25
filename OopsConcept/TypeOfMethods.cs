using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class TypeOfMethods
    {
        // Method with no return value and no parameters
        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        // Method with return value and parameters
        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        // Method with output parameters
        static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }

        // Method with variable number of arguments
        static double CalculateAverage(params double[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }

            return sum / numbers.Length;
        }

        public static void TypeOfMehodDemo()
        {
            // Method call with no return value and no parameters
            SayHello();

            // Method call with return value and parameters
            int result = AddNumbers(5, 3);
            Console.WriteLine("Addition Result: " + result);

            // Method call with output parameters
            int dividend = 10;
            int divisor = 3;
            int quotient, remainder;
            Divide(dividend, divisor, out quotient, out remainder);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);

            // Method call with variable number of arguments
            double average1 = CalculateAverage(2.5, 3.7, 4.1);
            Console.WriteLine("Average 1: " + average1);

            double average2 = CalculateAverage(1.2, 5.6, 3.8, 2.4, 4.9);
            Console.WriteLine("Average 2: " + average2);
        }
    }
}
