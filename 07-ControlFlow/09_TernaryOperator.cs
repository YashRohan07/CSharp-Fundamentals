using System;

namespace _07_ControlFlow
{
    public class TernaryOperator
    {
        public static void Run()
        {
            Introduction();
            BasicExample();
            AgeExample();
            MaxNumberExample();
        }

        // INTRODUCTION
        static void Introduction()
        {
            // Ternary operator is a short form of if-else

            // Syntax:
            // variable = (condition) ? value_if_true : value_if_false;

            // if condition is true → first value
            // else → second value

            Console.WriteLine("Short form of if-else statement.\n");
        }

        // EXAMPLE 1: Basic
        static void BasicExample()
        {
            int time = 20;

            string result = (time < 18) ? "Good day" : "Good evening";

            Console.WriteLine(result);

            /*
             time = 20
             condition: time < 18 → false

             OUTPUT: Good evening
            */

        }

        // EXAMPLE 2: Age Check
        static void AgeExample()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string status = (age >= 18) ? "Adult" : "Minor";

            Console.WriteLine("Status: " + status);

            /*
             INPUT: 17 → Minor
             INPUT: 20 → Adult

             replaces simple if-else
            */

        }

        // EXAMPLE 3: Find Maximum
        static void MaxNumberExample()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int max = (a > b) ? a : b;

            Console.WriteLine("Max = " + max);

            /*
             INPUT: 5, 10
             OUTPUT: Max = 10

             condition (a > b)
             true → a
             false → b
            */

        }
    }
}