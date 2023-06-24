namespace OopsConcept
{
    //1) Create a program with object and class concept with example.
    class Car
    {
        // Class properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Class constructor
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        // Class method
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
            Car myCar = new Car("Ford", "Mustang", 2022);

            // Accessing object properties
            Console.WriteLine($"Brand: {myCar.Brand}");
            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");

            // Call object method
            myCar.StartEngine();
        }
    }
}