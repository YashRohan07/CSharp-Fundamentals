using System;

namespace _07_ControlFlow
{
    public class ForeachLoop
    {
        public static void Run()
        {
            Introduction();
            LoopArray();
            LoopNumbers();
        }

        // INTRODUCTION
        static void Introduction()
        {
            // foreach loop is used to go through each item in a collection
            // collection = array, list, etc.
            // instead of using index (i), it gives each value directly

            Console.WriteLine("Used to loop through arrays or collections.");
            Console.WriteLine("No need to use index (i).\n");
        }

        // EXAMPLE 1: Loop through string array
        static void LoopArray()
        {
            // array of names
            string[] names = { "Rohan", "Yash", "Rahim" };

            // foreach takes each item one by one
            // name → holds current value
            // names → collection

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            /*
             OUTPUT:
             Rohan
             Yash
             Rahim

             It automatically goes one by one
             No need for index like names[i]
            */

        }

        // EXAMPLE 2: Loop through numbers
        static void LoopNumbers()
        {
            int[] numbers = { 10, 20, 30, 40 };

            int sum = 0;

            foreach (int num in numbers)
            {
                Console.WriteLine("Number: " + num);

                // adding each number
                sum += num;
            }

            Console.WriteLine("Total Sum = " + sum);

            /*
             OUTPUT:
             Number: 10
             Number: 20
             Number: 30
             Number: 40
             Total Sum = 100

             foreach is very useful for reading data
             best for summing, printing, processing
            */

        }
    }
}