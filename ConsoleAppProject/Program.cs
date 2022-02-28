﻿using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("                                                   ");
            Console.WriteLine("   BNU CO453 Applications Programming 2021-2022!   ");
            Console.WriteLine("                                                   ");
            Console.WriteLine("                      App 01                       ");
            Console.WriteLine("                                                   ");

            DistanceConverter app01 = new DistanceConverter();

            app01.ConvertDistance();
        }
    }
}
