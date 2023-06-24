using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    //Create a program with Abstraction concept.
    // Abstract class definition
    public abstract class Shape1
    {
        public abstract void Draw(); // Abstract method

        public void DisplayArea() // Non-abstract method
        {
            Console.WriteLine("Calculating area...");
        }
    }

    // Derived class implementing the abstract method
    class Circle1 : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    // Derived class implementing the abstract method
    class Rectangle1 : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    public  class AbstractionDemo
    {
       public static void AbstractionMethod()
        {
            Shape1 shape1 = new Circle1();     // Create a Circle object
            Shape1 shape2 = new Rectangle1();  // Create a Rectangle object

            shape1.Draw();  // Calls the overridden Draw() method in Circle class
            shape1.DisplayArea();  // Calls the non-abstract method in Shape class

            shape2.Draw();  // Calls the overridden Draw() method in Rectangle class
            shape2.DisplayArea();  // Calls the non-abstract method in Shape class
        }
    }
}
