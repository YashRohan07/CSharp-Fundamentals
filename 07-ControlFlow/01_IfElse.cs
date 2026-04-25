using System;

namespace _07_ControlFlow
{
    public class IfElse
    {
        // Entry method for this file
        public static void Run()
        {
            Introduction();
            SimpleIf();
            BasicIfElse();
            EvenOddCheck();
            PositiveNegativeCheck();
            MaxOfTwoNumbers();
        }

        // What is If-Else
        static void Introduction()
        {
            Console.WriteLine("Used to make decisions in a program.");
            Console.WriteLine("If condition is TRUE → run IF block");
            Console.WriteLine("If condition is FALSE → run ELSE block\n");
        }

        // Simple IF Only
        static void SimpleIf()
        {
            // only IF (no else)

            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            /*
             condition: 20 > 18 → TRUE

             OUTPUT: 20 is greater than 18

             If condition is FALSE → nothing will run
            */

        }

        // Basic Example
        static void BasicIfElse()
        {
            int age = 18;

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }

            Console.WriteLine();
        }

        // Example 1: Even / Odd
        static void EvenOddCheck()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.WriteLine();
        }

        // Example 2: Positive / Negative
        static void PositiveNegativeCheck()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative or Zero");
            }

            Console.WriteLine();
        }

        // Example 3: Find Maximum
        static void MaxOfTwoNumbers()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Max = " + a);
            }
            else
            {
                Console.WriteLine("Max = " + b);
            }

            Console.WriteLine();
        }
    }
}