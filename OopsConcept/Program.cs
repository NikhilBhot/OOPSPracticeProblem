namespace OopsConcept
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }
    }
    //1) Create a program with object and class concept with example.
    //Create a program with Inheritance concept with example.
    class Car : Vehicle

    {
        public string Model { get; set; }

        public void StartEngine()
        {
            Console.WriteLine("Engine started. Vroom!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Car class
            Car myCar = new Car();
            myCar.Brand = "Ford";
            myCar.Model = "Mustang";
            myCar.Year = 2022;

            // Accessing inherited property
            Console.WriteLine($"Brand: {myCar.Brand}");
            Console.WriteLine($"Year: {myCar.Year}");

            // Accessing derived class property
            Console.WriteLine($"Model: {myCar.Model}");

            // Call inherited method
            myCar.Honk();

            // Call derived class method
            myCar.StartEngine();

            Console.WriteLine("_____________________________");
            Console.WriteLine("Polymorphisum Example");
            DemoPolymorphisum.Polymorphism();

            Console.WriteLine("_____________________________");
            Console.WriteLine("Encapsulation Example");
            EncapusulationDemo.EncapsulationDemoMethod();


            Console.WriteLine("_____________________________");
            Console.WriteLine("Abstraction Example");
            AbstractionDemo.AbstractionMethod();

            Console.WriteLine("_____________________________");
            Console.WriteLine("Data Type Example");
            DataType.DataTypeMethod();

            Console.WriteLine("_____________________________");
            Console.WriteLine("Type OF Method Example");
            TypeOfMethods.TypeOfMehodDemo();
        }
    }
}