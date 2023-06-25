using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    // Single Inheritance
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    // Multilevel Inheritance
    class Labrador : Dog
    {
        public void Run()
        {
            Console.WriteLine("Labrador is running.");
        }
    }

    // Hierarchical Inheritance
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Cat is meowing.");
        }
    }

    // Interface for Multiple Inheritance
    interface IJumpable
    {
        void Jump();
    }

    // Multiple Inheritance using Interfaces
    class Kangaroo : Animal, IJumpable
    {
        public void Jump()
        {
            Console.WriteLine("Kangaroo is jumping.");
        }
    }

    public class TypesOfInheritance
    {
       public static void InheritanceClassMethod()
        {
            // Single Inheritance Example
            Dog dog = new Dog();
            dog.Eat();  // Inherited method from Animal class
            dog.Bark(); // Method from Dog class
            Console.WriteLine();

            // Multilevel Inheritance Example
            Labrador labrador = new Labrador();
            labrador.Eat();  // Inherited method from Animal class
            labrador.Bark(); // Inherited method from Dog class
            labrador.Run();  // Method from Labrador class
            Console.WriteLine();

            // Hierarchical Inheritance Example
            Cat cat = new Cat();
            cat.Eat();  // Inherited method from Animal class
            cat.Meow(); // Method from Cat class
            Console.WriteLine();

            // Multiple Inheritance using Interfaces Example
            Kangaroo kangaroo = new Kangaroo();
            kangaroo.Eat();  // Inherited method from Animal class
            kangaroo.Jump(); // Method from IJumpable interface
        }
    }
}
