using ConsoleAppProject.App01;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Maarten Vanderbeeken 04/01/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;
            
            Console.WriteLine("BNU CO453 Applications Programming 2021-2022!");
            Console.WriteLine("                App01                        ");
            Console.WriteLine("         Distance Converter  >               ");

            DistanceConverter converter = new DistanceConverter();

            converter.MilesToFeet();
            converter.FeetToMiles();
            converter.MilesToMeters();
        }

    }
}
