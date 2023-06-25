using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class ValueAndReferenceType
    {
        public static void ValueAndReferenceTypeMetthod()
        {
            // Value Type: int
            int x = 10;
            int y = x; // Copying the value of x to y
            y = 20;   // Modifying the value of y

            Console.WriteLine("Value Type Example:");
            Console.WriteLine("x: " + x); // Output: 10
            Console.WriteLine("y: " + y); // Output: 20
            Console.WriteLine();

            // Reference Type: Array
            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1; // Copying the reference to array1

            array2[0] = 4; // Modifying the object referred to by array2

            Console.WriteLine("Reference Type Example:");
            Console.WriteLine("array1[0]: " + array1[0]); // Output: 4
            Console.WriteLine("array2[0]: " + array2[0]); // Output: 4
        }
    }
}
