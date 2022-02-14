using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app lets a user enter a unit of distance in miles, feet or meters
    /// Then calculates each value from miles to feet, feet to miles
    /// and miles to meters, then outputs the equivalent distance.
    /// </summary>
    /// <author>
    /// Maarten Vanderbeeken version 1.2
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double meters;

        /// <summary>
        /// This method outputs a heading to let the user know the
        /// purpose of the application.
        /// </summary>
        private void OutputHeading(string prompt)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine();
            Console.WriteLine("   ===================================   ");
            Console.WriteLine("                                         ");
            Console.WriteLine("           Distance Converter            ");
            Console.WriteLine("         By Maarten Vanderbeeken         ");
            Console.WriteLine("                                         ");
            Console.WriteLine("   ===================================   ");
            Console.WriteLine();

            Console.WriteLine(prompt);
            Console.WriteLine();
        }

        /// <summary>
        /// This method will display a heading and ask the user to
        /// input a number of distance measured in miles then
        /// calculate the same distance in feet and output the
        /// distance in feet.
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            miles = InputDistance("Please enter the number of miles > ");

            CalculateFeet();

            OutputDistance(miles, nameof(miles), feet, nameof(feet));
        }
        /// <summary>
        /// This method will display a heading and ask the user to
        /// input a number of distance measured in feet then
        /// calculate the same distance in miles and output the
        /// distance in miles.
        /// </summary>
        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            feet = InputDistance("Please enter the number of feet > ");

            CalculateMiles();

            OutputDistance(feet, nameof(feet), miles, nameof(miles));
        }
        /// <summary>
        /// This method will display a heading and ask the user to
        /// input a number of distance measured in miles then
        /// calculate the same distance in meters and output the
        /// distance in meters.
        /// </summary>
        public void MilesToMeters()
        {
            OutputHeading("Converting Miles to Meters");

            miles = InputDistance("Please enter the number of miles > ");

            CalculateMeters();

            OutputDistance(miles, nameof(miles), meters, nameof(meters));
        }
 
        /// <summary>
        /// Promt the user to enter the distance in miles
        /// Input the miles as a double number.
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }
      
        /// <summary>
        /// A method to calculate and convert miles to feet.
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }
        /// <summary>
        /// A method to calculate and convert feet to miles.
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }
        /// <summary>
        /// A method to calculate and convert miles to meters.
        /// </summary>
        private void CalculateMeters()
        {
            meters = miles * METERS_IN_MILES; 
        }
        /// <summary>
        /// This method outputs a result of the converted number.
        /// </summary>
        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
        {
            Console.WriteLine($" {fromDistance} {fromUnit} =" +
                $" {toDistance} {toUnit}!");
        }
    }
}
