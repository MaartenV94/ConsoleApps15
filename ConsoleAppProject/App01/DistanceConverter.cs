using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app lets a user enter a unit of distance in miles
    /// Then is calculated into feet and outputs the result
    /// </summary>
    /// <author>
    /// Maarten Vanderbeeken version 1.0
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;

        /// <summary>
        /// This method will input the distance measured in miles
        /// calculate the same distance in feet, and output the
        /// distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            InputMiles();
            InputFeet();
            CalculateFeet();
            CalculateMiles();
            OutputFeet();
        }

        private void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("   -----------------------------------   ");
            Console.WriteLine("            Distance Converter           ");
            Console.WriteLine("          By Maarten Vanderbeeken        ");
            Console.WriteLine("                                         ");
            Console.WriteLine("      What would you like to convert?    ");
            Console.WriteLine("                                         ");
            Console.WriteLine("           Convert Miles to Feet >       ");
            Console.WriteLine("                   or                    ");
            Console.WriteLine("           Convert Feet to Miles >       ");
            Console.WriteLine("   -----------------------------------   ");
            Console.WriteLine();
        }

        /// <summary>
        /// Promt the user to enter the distance in miles
        /// Input the miles as a double number.
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        private void CalculateMiles()
        {
            miles = feet / 5280;
        }

        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }
    }
}
