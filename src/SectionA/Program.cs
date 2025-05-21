// src/SectionA/Program.cs
using System;

namespace SectionA
{
    class Program
    {
        // This static field represents "global" variables in the context of this class.
        static string message = "Hello from Global!";

        static void Main(string[] args)
        {
            // This is the entry point of the program.
            Console.WriteLine("===SECTION A: VARIABLE SCOPE===");
            Console.WriteLine("\nChoose an example:");
            Console.WriteLine("1. Local vs Global Variables");
            Console.WriteLine("2. Formal Parameters");
            Console.WriteLine("\nEnter your choice (1-2): ");

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    LocalVsGlobal();
                    break;
                case "2":
                    Console.WriteLine("\nEnter first number: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number: ");
                    int b = int.Parse(Console.ReadLine());
                    AddNumbers(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        // Example 1: Local vs Global Variables
        static void LocalVsGlobal()
        {
            // This is a local variable "shadows" the global variable with the same name.
            string localMessage = "Hello from Local!";
            Console.WriteLine("\n===Local vs Global Variables===");
            Console.WriteLine($"Local Message: {localMessage}"); // Accessing the local variable
            Console.WriteLine($"Global Message: {Program.message}");// Accessing the global variable

            // Accessing the global variable directly
            AnotherMethod();
        }


        static void AnotherMethod()
        {
            // Here we can access message directly as there's no local variable with the same name.
            Console.WriteLine($"Accessing global from another method: {message}");
        }
        // Example 2: Formal Parameters
        static void AddNumbers(int a, int b)
        {
            // This method takes two parameters and adds them.
            int sum = a + b;
            Console.WriteLine($"\n===Formal Parameters===");
            Console.WriteLine($"First parameter (a): {a}");
            Console.WriteLine($"Second parameter (b): {b}");
            Console.WriteLine($"Sum of {a} and {b} is: {sum}");
        }
    }
}