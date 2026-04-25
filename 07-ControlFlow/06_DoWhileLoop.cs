using System;

namespace _07_ControlFlow
{
    public class DoWhileLoop
    {
        public static void Run()
        {
            Introduction();
            BasicDoWhile();
            RunAtLeastOnceExample();
            MenuExample();
        }

        // INTRODUCTION
        static void Introduction()
        {
            // runs the code first
            // then checks the condition

            // do-while loop always runs at least one time
            // even if the condition is false

            Console.WriteLine("do-while loop runs at least once.");
            Console.WriteLine("First it runs the code, then it checks the condition.\n");
        }

        // BASIC DO-WHILE EXAMPLE
        static void BasicDoWhile()
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);

            /*
             OUTPUT:
             1
             2
             3
             4
             5

             First i = 1
             Loop prints i
             Then i increases by 1
             Loop continues while i <= 5
            */

        }

        // EXAMPLE 2: Runs at least once
        static void RunAtLeastOnceExample()
        {
            int number = 10;

            do
            {
                Console.WriteLine("This line runs one time.");
            }
            while (number < 5);

            /*
             OUTPUT:
             This line runs one time.

             Here number = 10
             Condition is number < 5
             This condition is false

             But do-while still runs one time
             because condition is checked after running the code
            */

        }

        // EXAMPLE 3: Menu system
        static void MenuExample()
        {
            int choice;

            do
            {
                Console.WriteLine("1. Say Hello");
                Console.WriteLine("2. Show Message");
                Console.WriteLine("3. Exit");

                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Hello!");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Welcome to C# learning.");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Exiting menu...");
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine();

            } while (choice != 3);

            /*
             SAMPLE OUTPUT:
             1. Say Hello
             2. Show Message
             3. Exit
             Enter choice: 1
             Hello!

             1. Say Hello
             2. Show Message
             3. Exit
             Enter choice: 3
             Exiting menu...

             Menu keeps running until user enters 3
            */
        }
    }
}