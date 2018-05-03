using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Car
    {
        // Defining properties
        public string Color { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }


        //adding a Constructor 
        // This constructor instantiates a Car() object while only having the car's color and year information available
        public Car(string color, int year)
        {
            this.Color = color;
            this.Year = year;
            // Every time the constructor runs, increment "instances"
            instances++;
        }
        
        //Adding another Constructor
        // This constructor instantiates a Car() object while only having the car's year and mileage information available
        public Car(int year, int mileage)
        {
            this.Year = year;
            this.Mileage = mileage;
            // Every time the constructor runs, increment "instances"
            instances++;
        }
/*
 *                                      INSTANCES
 * */
        public Car()
        {
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        // Creates integer variable called "instances" and assigns value to 0
        private static int instances = 0;

        // Declare static member
        public static int CountCars()
        {
            return instances;
        }
    }
}
