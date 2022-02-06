﻿using System;

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
        private double miles;

        private double feet;

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Promt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        private void CalculateFeet()
        {

        }

        private void OutputFeet()
        {

        }
    }
}
