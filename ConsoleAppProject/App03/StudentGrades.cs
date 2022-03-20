using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// App03 Students Grades allows the user to enter
    /// a mark for each student in the list and convert
    /// the students marks into grades. It will also
    /// calculate the statistics and grade profiles of
    /// all the students and then outputs all the results.
    /// </summary>
    public class StudentGrades
    {
        public const int MIN_FAIL = 0;
        public const int MIN_D = 40;
        public const int MIN_C = 50;
        public const int MIN_B = 60;
        public const int MIN_A = 70;
        public const int MAX_PASS = 100;

        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }
        public int Maximum { get; set; }

        /// <summary>
        /// This method will run the program and then
        /// close the program if the user does not wish
        /// to run again.
        /// </summary>
        public void Run()
        {
            bool repeat = true;
            while (repeat)
            {
                repeat = ConsoleHelper.Repeat();
            }
        }

        /// <summary>
        /// This method contains the name of all ten students,
        /// Then runs the methods to input a mark, output a grade,
        /// calculate the statistics and finally calculate
        /// the grade profiles of every student.
        /// </summary>
        public StudentGrades()
        {
            Students = new string[] { "Jeremy", "Mark", "Sophie", "Hans", "Alan", "Jeff", "Dobby", "Nancy", "Tony", "Toni", };
            Marks = new int[Students.Length];
            GradeProfile = new int[(int)Grades.A + 1];

            ConsoleHelper.OutputHeading(" App-03 Student Grades ");
            InputMarks();
            OutputGrades();
            CalculateStats();
            CalculateGradeProfile();
        }

        /// <summary>
        /// This method will allow the user to input a mark between
        /// the numbers 0 and 100 for every student which is then stored
        /// in the marks array.
        /// </summary>
        private void InputMarks()
        {
            Console.WriteLine("Please enter a mark for each student >\n");
            int i = 0;

            foreach (string name in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($"Enter {name}'s mark > ", 0, 100);
                Marks[i] = mark;
                i++;
            }
            OutputGrades();
        }

        /// <summary>
        /// This method will output the name of the students and the
        /// mark percentage and the grade.
        /// </summary>
        private void OutputGrades()
        {
            ConsoleHelper.OutputTitle("Here is a list of all the students Mark's and Grades \n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            for (int i = 0; i < Students.Length; i++)

            {
                int mark = Marks[i];
                Grades grade = ConvertToGrades(mark);
                Console.WriteLine($"{Students[i]} Mark = {Marks[i]}% - Grade = {grade}");
            }
        }

        /// <summary>
        /// This method will convert the students mark into a grade,
        /// from the highest grade A (First class) to the lowest F
        /// (Fail).
        /// </summary>
        public Grades ConvertToGrades(int mark)
        {
            if (mark >= MIN_FAIL && mark <= MIN_D)
            {
                return Grades.F;
            }
            else if (mark >= MIN_D && mark <= MIN_C)
            {
                return Grades.D;
            }
            else if (mark >= MIN_C && mark <= MIN_B)
            {
                return Grades.C;
            }
            else if (mark >= MIN_B && mark <= MIN_A)
            {
                return Grades.B;
            }
            else if (mark >= MIN_A && mark <= MAX_PASS)
            {
                return Grades.A;
            }
            else
            {
                return Grades.X;
            }
        }

        /// <summary>
        /// In this method the minimum, maximum and mean mark of
        /// all the students will be calculated.
        /// </summary>
        public void CalculateStats()
        {
            double total = 0;

            Minimum = MAX_PASS;
            Maximum = 0;

            foreach (int mark in Marks)
            {
                total = total + mark;
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
            }
            Mean = total / Marks.Length;

            OutputStats();
        }

        /// <summary>
        /// This method outputs and dislays the results from the previous
        /// method showing the minimum, maximum and mean mark.
        /// </summary>
        public void OutputStats()
        {
            ConsoleHelper.OutputTitle(" Student Marks Statistics");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine($" Number of students marked = {Marks.Length}");
            Console.WriteLine($" Minimum mark = {Minimum}");
            Console.WriteLine($" Maximum mark = {Maximum}");
            Console.WriteLine($" Mean mark = {Mean}");
        }

        /// <summary>
        /// This method calculates the percantage of students that have
        /// obtained each grade.
        /// </summary>
        public void CalculateGradeProfile()
        {
            for(int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrades(mark);
                GradeProfile[(int)grade]++;
            }

            OutputGradeProfile();
        }

        /// <summary>
        /// This method will output and display the grade profile.
        /// </summary>
        private void OutputGradeProfile()
        {
            Grades grade = Grades.X;
            ConsoleHelper.OutputTitle(" Number of students that achieved " + "the following grades");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($" Grade {grade} - {percentage}% | Count {count}");
                grade++;
            }
        }
    }
}
