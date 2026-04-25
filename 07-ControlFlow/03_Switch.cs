using System;

namespace _07_ControlFlow
{
    public class Switch
    {
        public static void Run()
        {
            Introduction();
            DayExample();
            CalculatorExample();
        }

        // What is Switch
        static void Introduction()
        {
            Console.WriteLine("Used as an alternative to multiple else-if conditions.\n");
        }

        // Example 1: Day of Week
        static void DayExample()
        {
            Console.Write("Enter number (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid number");
                    break;
            }

            Console.WriteLine();
        }

        // Example 2: Simple Calculator
        static void CalculatorExample()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Choose operation (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result = " + (a + b));
                    break;

                case '-':
                    Console.WriteLine("Result = " + (a - b));
                    break;

                case '*':
                    Console.WriteLine("Result = " + (a * b));
                    break;

                case '/':
                    Console.WriteLine("Result = " + (a / b));
                    break;

                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            Console.WriteLine();
        }
    }
}