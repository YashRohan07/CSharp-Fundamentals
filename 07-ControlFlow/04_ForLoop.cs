using System;

namespace _07_ControlFlow
{
    public class ForLoop
    {
        public static void Run()
        {
            Introduction();
            BasicLoop();
            SumOfNumbers();
            MultiplicationTable();
            ReverseNumber();
            FactorialExample();
        }

        // INTRODUCTION
        static void Introduction()
        {
            // used when we know how many times to repeat

            // structure:
            // for (start; condition; update)

            // start → where loop begins
            // condition → when loop runs
            // update → how value changes

            Console.WriteLine("Used when we know how many times to repeat.");
            Console.WriteLine("Structure: for(start; condition; update)\n");
        }

        // BASIC EXAMPLE
        static void BasicLoop()
        {
            Console.WriteLine("Print 1 to 5:");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            /*
             OUTPUT:
             1
             2
             3
             4
             5

             i starts from 1
             loop runs while i <= 5
             i++ increases i by 1 each time
            */

        }

        // EXAMPLE 1: Sum of numbers
        static void SumOfNumbers()
        {
            int sum = 0;

            for (int i = 1; i <= 5; i++)
            {
                sum += i; // same as sum = sum + i
            }

            Console.WriteLine("Sum = " + sum);

            /*
             PROCESS:
             sum = 0
             sum = 0 + 1 = 1
             sum = 1 + 2 = 3
             sum = 3 + 3 = 6
             sum = 6 + 4 = 10
             sum = 10 + 5 = 15

             OUTPUT:
             Sum = 15
            */

        }

        // EXAMPLE 2: Multiplication Table
        static void MultiplicationTable()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }

            /*
             INPUT: 5

             OUTPUT:
             5 x 1 = 5
             5 x 2 = 10
             ...
             5 x 10 = 50
            */

        }

        // EXAMPLE 3: Reverse Number
        static void ReverseNumber()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            // while loop used because number size is unknown
            while (num != 0)
            {
                int digit = num % 10;       // get last digit
                reverse = reverse * 10 + digit;
                num /= 10;                 // remove last digit
            }

            Console.WriteLine("Reversed = " + reverse);

            /*
             INPUT: 1234

             PROCESS:
             1234 → 4
             123 → 3
             12 → 2
             1 → 1

             OUTPUT: Reversed = 4321
            */

        }

        // EXAMPLE 4: Factorial
        static void FactorialExample()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i; // multiply each number
            }

            Console.WriteLine("Factorial = " + factorial);

            /*
             INPUT: 5

             PROCESS:
             1 * 1 = 1
             1 * 2 = 2
             2 * 3 = 6
             6 * 4 = 24
             24 * 5 = 120

             OUTPUT: Factorial = 120
            */

        }
    }
}