// src/SectionE/Program.cs
using System;

namespace SectionE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SECTION E: Software Testing Practicals ===");
            Console.WriteLine("Choose a week to explore:");
            Console.WriteLine("1. Week 1 - Introduction to Unit Testing");
            Console.WriteLine("2. Week 2 - Testing Existing Classes");
            Console.WriteLine("3. Week 3 - Advanced Testing Concepts");
            Console.WriteLine("4. Week 4 - Test-Driven Development (TDD)");
            Console.WriteLine("Enter your choice (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Week1();
                    break;
                case "2":
                    Week2();
                    break;
                case "3":
                    Week3();
                    break;
                case "4":
                    Week4();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void Week1()
        {
            Console.WriteLine("\nWeek 1: Introduction to Unit Testing");
            Console.WriteLine("This week covers setting up xUnit and writing basic tests.");
            Console.WriteLine("Please open the tests/Week1 project to explore the tests.");
        }

        static void Week2()
        {
            Console.WriteLine("\nWeek 2: Testing Existing Classes");
            Console.WriteLine("This week focuses on unit tests for classes like Circle, Product, etc.");
            Console.WriteLine("Please open the tests/Week2 project to explore the tests.");
        }

        static void Week3()
        {
            Console.WriteLine("\nWeek 3: Advanced Testing Concepts");
            Console.WriteLine("This week covers mocks, edge cases, and UserAccount login tests.");
            Console.WriteLine("Please open the tests/Week3 project to explore the tests.");
        }

        static void Week4()
        {
            Console.WriteLine("\nWeek 4: Test-Driven Development (TDD)");
            Console.WriteLine("This week demonstrates TDD with new feature development.");
            Console.WriteLine("Please open the tests/Week4 project to explore the tests.");
        }
    }
}
