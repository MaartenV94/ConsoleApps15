using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This application allows a user to calculate their
    /// Body Mass Index using metric or imperial system.
    /// </summary>
    /// <author>
    /// Maarten Vanderbeeken version 1.0
    /// </author>
    public class BMI_Calculator
    {
        public void Run()
        {
            ConsoleHelper.OutputHeading("BMI Calculator");
            int choice = InputChoice();
        }

        private int InputChoice()
        {
            string[] choices = new string[]
            {
                "Imperial Units",
                "Metric Units"
            };

            ConsoleHelper.OutputTitle("Please make your choice of units > ");
            return ConsoleHelper.SelectChoice(choices);
        }
    }
}