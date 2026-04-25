using System;

namespace _07_ControlFlow
{
    public class BreakContinue
    {
        public static void Run()
        {
            Introduction();
            BreakExample1();
            BreakExample2();
            ContinueExample1();
            ContinueExample2();
        }

        // INTRODUCTION
        static void Introduction()
        {
            // break:
            // stops the loop completely
            // loop will not continue after break

            // continue:
            // skips current iteration
            // loop continues with next iteration

            Console.WriteLine("break → stops the loop completely");
            Console.WriteLine("continue → skips current step and continues\n");
        }

        // BREAK EXAMPLE 1 (Basic)
        static void BreakExample1()
        {
            // Loop runs from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                // When i becomes 5 → break stops the loop
                if (i == 5)
                {
                    break; // loop ends here
                }

                Console.WriteLine(i);
            }

            /*
             OUTPUT:
             1
             2
             3
             4

             Loop stopped when i = 5
            */

        }

        // BREAK EXAMPLE 2 (Searching)
        static void BreakExample2()
        {
            int[] numbers = { 3, 7, 10, 15, 20 };

            int target = 10;

            for (int i = 0; i < numbers.Length; i++)
            {
                // Check if number is found
                if (numbers[i] == target)
                {
                    Console.WriteLine("Found at index: " + i);

                    break; // stop searching after found
                }
            }

            /*
             OUTPUT: Found at index: 2
             Once found, loop stops immediately
            */

        }

        // CONTINUE EXAMPLE 1 (Basic)
        static void ContinueExample1()
        {
            for (int i = 1; i <= 5; i++)
            {
                // Skip when i = 3
                if (i == 3)
                {
                    continue; // skip this step
                }

                Console.WriteLine(i);
            }

            /*
             OUTPUT:
             1
             2
             4
             5

             3 is skipped, but loop continues
            */

        }

        // CONTINUE EXAMPLE 2 (Skip Even Numbers)
        static void ContinueExample2()
        {
            for (int i = 1; i <= 10; i++)
            {
                // If number is even → skip it
                if (i % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            /*
             OUTPUT:
             1
             3
             5
             7
             9

             All even numbers skipped
            */

        }
    }
}