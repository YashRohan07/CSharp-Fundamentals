using System;

namespace _06_ProgramExecution._01_Traditional
{
    class Program
    {
        // Entry Point (start of program)
        // Traditional style: write Main()
        static void Main(string[] args)
        {
            // Flow: Main() → Run()
            MyClass.Run();

            Console.WriteLine("Program End");
        }
    }
}