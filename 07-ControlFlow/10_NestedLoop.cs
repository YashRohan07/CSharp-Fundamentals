using System;

namespace _07_ControlFlow
{
    public class NestedLoop
    {
        public static void Run()
        {
            Introduction();
            BasicNestedLoop();
            MultiplicationTableGrid();
            PatternExample();
        }

        // INTRODUCTION
        static void Introduction()
        {
            // Nested loop means: loop inside another loop

            // Outer loop → controls rows
            // Inner loop → runs fully for each outer loop

            Console.WriteLine("A loop inside another loop.\n");
        }

        // EXAMPLE 1: BASIC NESTED LOOP
        static void BasicNestedLoop()
        {
            for (int i = 1; i <= 2; i++) // outer loop
            {
                Console.WriteLine("Outer: " + i);

                for (int j = 1; j <= 3; j++) // inner loop
                {
                    Console.WriteLine("  Inner: " + j);
                }
            }

            /*
             OUTPUT:
             Outer: 1
               Inner: 1
               Inner: 2
               Inner: 3
             Outer: 2
               Inner: 1
               Inner: 2
               Inner: 3

             Inner loop runs fully for each outer loop
            */

        }

        // EXAMPLE 2: MULTIPLICATION TABLE GRID
        static void MultiplicationTableGrid()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write((i * j) + "\t"); // tab space
                }

                Console.WriteLine();
            }

            /*
             OUTPUT:
             1  2  3
             2  4  6
             3  6  9

             rows = outer loop
             columns = inner loop
            */

        }

        // EXAMPLE 3: PATTERN PRINTING
        static void PatternExample()
        {
            Console.WriteLine("Star Pattern:");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            /*
             OUTPUT:
             *
             * *
             * * *
             * * * *
             * * * * *

             Outer loop controls lines
             Inner loop controls stars
            */

        }
    }
}