﻿using System;

namespace ConsoleAppProject.Helpers
{

    /// <summary>
    /// This is a general purpose class containing methods
    /// that can be used by other console based classes.
    /// Methods to input numbers from the user, and ask the
    /// user to select a choice from a list of choices.
    /// There are methods for outputting a main heading
    /// and a title.
    /// <author>
    /// Maarten Vanderbeeken Version 1.2
    /// </author>
    /// </summary>
    public static class ConsoleHelper
    {

        /// <summary>
        /// This method displays a list of numbered choices to the
        /// user, they can then select a choice and and the choice 
        /// number is returned.  Choices start at 1.
        /// </summary>
        public static int SelectChoice(string[] choices)
        {
            // Display all the choices

            DisplayChoices(choices);

            // Get the user's choice

            int choiceNo = (int)InputNumber("\n Please enter your choice > ", 
                                            1, choices.Length);
            return choiceNo;
        }

        /// <summary>
        /// This displays all the available choices in a numbered
        /// list, starting at 1
        /// </summary>
        private static void DisplayChoices(string[] choices)
        {
            int choiceNo = 0;

            foreach (string choice in choices)
            {
                choiceNo++;
                Console.WriteLine($"    {choiceNo}.  {choice}");
            }
        }


        /// <summary>
        /// This method will display a prompt to the user and
        /// will return any number as a double.  Any exception
        /// will generate an error message.
        /// </summary>
        public static double InputNumber(string prompt)
        {
            double number = 0;
            bool isValid;

            do
            {
                Console.Write(prompt);
                string value = Console.ReadLine();

                try
                {
                    number = Convert.ToDouble(value);
                    if (number > 0)
                    {
                        isValid = true;
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nError! Number must be higher than 0\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        isValid = false;
                    }
                }
                catch (Exception)
                {
                    isValid = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n INVALID NUMBER!\n");
                }

            } while (!isValid);

            return number;
        }


        /// <summary>
        /// This method will prompt the user to enter a number
        /// between the min and max values includice.
        /// 
        /// Error messages will be displayed for an invalid number
        /// or a number outside the min or max values.
        /// The number returned can be cast as an (int/decimal)
        /// </summary>
        public static double InputNumber(string prompt, double min, double max)
        {
            bool isValid;
            double number;

            do
            {
                number = InputNumber(prompt);

                if (number < min || number > max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    isValid = false;
                    Console.WriteLine($"\nNumber must be between {min} and {max}\n");                }
                else isValid = true;

            } while (!isValid);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;

            return number;

        }

        /// <summary>
        /// Output a short heading in green for the application
        /// and the name of the author and a prompt to
        /// inform the use which units are being converted
        /// Please change the authors name.
        /// </summary>
        public static void OutputHeading(string heading)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(" -------------------------------------------");
            Console.WriteLine($"            {heading}          ");
            Console.WriteLine("         by Maarten Vanderbeeken            ");
            Console.WriteLine(" -------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        /// <summary>
        /// This method will display a yellow title underlined
        /// by dashes.
        /// </summary>
        public static void OutputTitle(string title)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine($"\n {title} ");
            Console.Write(" ");

            for(int count = 0; count <= title.Length; count++)
            {
                Console.Write("-");
            }

            Console.WriteLine("\n");
            Console.ResetColor();
        }

        /// <summary>
        /// This method will give the user the option to carry
        /// out another calculation by saying yes or no
        /// </summary>
        public static bool Repeat()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("\n Would you like to carry out"
                    + " another calculation? yes/no? > ");
                string choice = Console.ReadLine();

                if (choice.ToLower().Contains("y"))
                {
                    Console.WriteLine(" You have selected yes");
                    repeat = false;
                    return true;
                }

                else if (choice.ToLower().Contains("n"))
                {
                    Console.WriteLine(" You have selected no");
                    repeat = false;
                    return false;
                }

                else
                {
                    Console.WriteLine(" Error: invalid input. Please try again");
                }
            }
            return false;

        }
    }
}
