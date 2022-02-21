using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will give the user a promt to input a chosen distance
    /// (fromUnit) and then calculates and outputs the result of the
    /// the conversion in another unit (toUnit).
    /// </summary>
    /// <author>
    /// Maarten Vanderbeeken version 1.3
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        public const double FEET_IN_METERS = 3.28084;

        public const string FEET = "Feet";
        public const string METERS = "Meters";
        public const string MILES = "Miles";

        private double fromDistance;
        private double toDistance;

        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        /// <summary>
        /// This method displays a heading to tell the user what
        /// unit of distance they are converting. Then asks the user
        /// to input a number of distance measured in miles then
        /// calculate the same distance in feet and outputs the
        /// distance in feet.
        /// </summary>
        public void ConvertDistance()
        {
            OutputHeading();

            fromUnit = SelectUnit(" Please select the from distance unit > ");
            toUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($"\n Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($" Please enter the number of {fromUnit} > ");

            CalculateDistance();

            OutputDistance();
        }

        /// <summary>
        /// This method outputs a heading to let the user know the
        /// purpose of the application. Then asks the user to enter
        /// a number that they wish to convert.
        /// </summary>
        private void OutputHeading()
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

        }

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

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);
            Console.WriteLine($"\n You have selected {unit}");
            return unit;
        }

        private static string ExecuteChoice(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice == "2")
            {
                return METERS;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METERS}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// This method promts the user to input a unit that they
        /// wish to be converted and is displayed at the start of
        /// each convertion with the Output heading class.
        /// </summary>
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }
      
        /// <summary>
        /// This method outputs a result of the converted number.
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($"\n {fromDistance} {fromUnit} =" +
                $" {toDistance} {toUnit}\n");
        }
    }
}
