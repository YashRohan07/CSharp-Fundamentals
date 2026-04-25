using System;

namespace _07_ControlFlow
{
    public class ElseIf
    {
        public static void Run()
        {
            Introduction();
            GradeSystem();
            NumberCategory();
        }

        // What is Else-If
        static void Introduction()
        {
            Console.WriteLine("Used when multiple conditions are checked.\n");
        }

        // Example 1: Grade System
        static void GradeSystem()
        {
            Console.Write("Enter marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 80)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (marks >= 70)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade: B");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Grade: C");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            Console.WriteLine();
        }

        // Example 2: Number Category
        static void NumberCategory()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }

            Console.WriteLine();
        }
    }
}