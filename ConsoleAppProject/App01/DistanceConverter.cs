using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will give the user a promt to input a chosen distance
    /// (fromUnit) and then calculates and outputs the result of the
    /// the conversion in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Maarten Vanderbeeken version 1.5
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        public const double FEET_IN_METERS = 3.28084;

        public const string FEET = "Feet";
        public const string METERS = "Meters";
        public const string MILES = "Miles";

        public double fromDistance { get; set; }
        public double toDistance { get; set; }

        public string fromUnit { get; set; }
        public string toUnit { get; set; }

        /// <summary>
        /// This method will run the program, output a heading and then
        /// ask the user if they wish to run it again.
        /// </summary>
        public void Run()
        {
            bool repeat = true;
            while(repeat)
            {
                
                ConsoleHelper.OutputHeading("Distance Converter");
                ConvertDistance();
                repeat = ConsoleHelper.Repeat();
            }
        }
        /// <summary>
        /// This method displays a heading to ask the user what
        /// unit of distance they want to convert from. Then asks
        /// the user what unit of distance they wish to convert to.
        /// Then it calculates the distance and outputs the result.
        /// </summary>
        public void ConvertDistance()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;

            string[] choices = new string[]
            {
                FEET, METERS, MILES
            };

            Console.WriteLine($"\nPlease select the distance unit you wish to convert from >\n ");
            int choice = ConsoleHelper.SelectChoice(choices);
            fromUnit = choices[choice - 1];
            Console.WriteLine($"You have selected {fromUnit} ");

            Console.WriteLine($"\nPlease select the distance unit you wish to convert to >\n ");
            choice = ConsoleHelper.SelectChoice(choices);
            toUnit = choices[choice - 1];
            Console.WriteLine($"\nYou have selected {toUnit} \n");

            fromDistance = ConsoleHelper.InputNumber($"\n Please enter the distance in {fromUnit} \n> ");

            ConsoleHelper.OutputTitle($"\nConverting {fromUnit} to {toUnit} \n");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// This method contains six calculations to convert between miles,
        /// feet and meters.
        /// </summary>
        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == METERS && toUnit == MILES)
            {
                toDistance = fromDistance / METERS_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METERS)
            {
                toDistance = fromDistance * METERS_IN_MILES;
            }
            else if (fromUnit == METERS && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METERS;
            }
            else if (fromUnit == FEET && toUnit == METERS)
            {
                toDistance = fromDistance / FEET_IN_METERS;
            }
        }
      
        /// <summary>
        /// This method outputs a result of the converted number.
        /// </summary>
        private void OutputDistance()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"\n {fromDistance} {fromUnit} =" +
                $" {toDistance} {toUnit}\n");
        }
    }
}
