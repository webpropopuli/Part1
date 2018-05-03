using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car1 = new Car();
            var Car2 = new Car( "Red", 2008 );  

            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            // Access static members
            int carCount = Car.CountCars();

            // Output to the console window
            Console.WriteLine( $"There are {carCount} cars on inventory right now." );
        }
    }
}
