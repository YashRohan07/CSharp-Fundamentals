using System;

namespace _07_ControlFlow
{
    public class WhileLoop
    {
        public static void Run()
        {
            Introduction();
            BasicWhile();
            SumUntilInput();
            CountDigits();
            GuessNumberGame();
        }

        // INTRODUCTION
        static void Introduction()
        {
            // runs again and again while condition is TRUE

            // first check condition
            // if true → run
            // if false → stop

            Console.WriteLine("Runs while condition is TRUE.");
            Console.WriteLine("If condition becomes FALSE → loop stops.\n");
        }

        
        // BASIC EXAMPLE
        static void BasicWhile()
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++; // very important (otherwise infinite loop)
            }

            /*
             OUTPUT:
             1
             2
             3
             4
             5

             Loop starts with i = 1
             Runs while i <= 5
             i++ increases value each time
            */

        }

        // EXAMPLE 1: Sum until user enters 0
        static void SumUntilInput()
        {
            int sum = 0;
            int num;

            Console.WriteLine("Enter numbers (0 to stop):");

            while (true) // infinite loop (runs forever)
            {
                num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                    break; // stop loop

                sum += num;
            }

            Console.WriteLine("Total Sum = " + sum);

            /*
             SAMPLE INPUT:
             5
             3
             2
             0

             OUTPUT: Total Sum = 10

             Loop runs until user enters 0
             break stops the loop
            */

        }

        // EXAMPLE 2: Count digits
        static void CountDigits()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (num != 0)
            {
                num /= 10; // remove last digit
                count++;
            }

            Console.WriteLine("Total digits = " + count);

            /*
             INPUT: 12345

             PROCESS:
             12345 → 1234 → 123 → 12 → 1 → 0

             OUTPUT:
             Total digits = 5
            */

        }

        // EXAMPLE 3: Guess Number Game
        static void GuessNumberGame()
        {
            int secretNumber = 7;
            int guess;

            Console.WriteLine("Guess the number (between 1-10):");

            while (true)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretNumber)
                {
                    Console.WriteLine("Correct! You guessed it.");
                    break; // stop loop when correct
                }
                else
                {
                    Console.WriteLine("Wrong! Try again.");
                }
            }

            /*
             SAMPLE OUTPUT:
             Guess the number:
             3 → Wrong
             5 → Wrong
             7 → Correct

             Loop continues until correct answer
            */

        }
    }
}