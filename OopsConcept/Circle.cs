using OopsConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    //Create a program with Polymorphism concept along with types of polymorphism.
    // Base class definition
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    // Derived class inheriting from the base class
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    // Another derived class inheriting from the base class
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

}
public class DemoPolymorphisum
{
    public static void Polymorphism()
    {
        Shape shape1 = new Circle();     // Create a Circle object
        Shape shape2 = new Rectangle();  // Create a Rectangle object

        // Polymorphism through method overriding
        shape1.Draw();  // Calls the overridden Draw() method in Circle class
        shape2.Draw();  // Calls the overridden Draw() method in Rectangle class

        // Polymorphism through method overloading
        DrawShape();                        // Calls the overloaded DrawShape() method with no arguments
        DrawShape(shape1);                  // Calls the overloaded DrawShape() method with Shape argument
        DrawShape(shape2, "blue");          // Calls the overloaded DrawShape() method with Shape and string arguments
    }

    // Polymorphism through method overloading
    static void DrawShape()
    {
        Console.WriteLine("Drawing a shape");
    }

    static void DrawShape(Shape shape)
    {
        shape.Draw();
    }

    static void DrawShape(Shape shape, string color)
    {
        Console.WriteLine($"Drawing a shape with color {color}");
        shape.Draw();
    }
}
