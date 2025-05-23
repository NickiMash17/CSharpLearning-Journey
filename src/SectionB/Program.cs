// src/SectionB/Program.cs
using System;

namespace SectionB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SECTION B: DATA TYPES ===");
            Console.WriteLine("\nChoose an example:");
            Console.WriteLine("1. Declare and Display Different Data Types");
            Console.WriteLine("2. Fix the Errors");
            Console.Write("\nEnter your choice (1-2): ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    DeclareAndDisplay();
                    break;
                case "2":
                    FixTheErrors();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        // Example 3: Declare and Display Different Data Types
        static void DeclareAndDisplay()
        {
            // Declare variables of different data types
            int age = 25;
            float price = 19.99f;  // Note the 'f' suffix for float literals
            double height = 5.9;
            char grade = 'A';
            bool isStudent = true;
            string name = "John";
            
            Console.WriteLine("\n=== Data Types and Their Values ===");
            
            // Display values with their types
            Console.WriteLine($"int age = {age} (Type: {age.GetType()})");
            Console.WriteLine($"float price = {price} (Type: {price.GetType()})");
            Console.WriteLine($"double height = {height} (Type: {height.GetType()})");
            Console.WriteLine($"char grade = {grade} (Type: {grade.GetType()})");
            Console.WriteLine($"bool isStudent = {isStudent} (Type: {isStudent.GetType()})");
            Console.WriteLine($"string name = {name} (Type: {name.GetType()})");
            
            // Additional information about the data types
            Console.WriteLine("\n=== Data Type Ranges ===");
            Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"float: {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
        }
        
        // Example 4: Fix the Errors
        static void FixTheErrors()
        {
            Console.WriteLine("\n=== Fixed Code with Original Errors ===");
            Console.WriteLine("Original code with errors:");
            Console.WriteLine("int number = \"10\";     // Error: Cannot implicitly convert string to int");
            Console.WriteLine("char letter = \"B\";     // Error: Cannot implicitly convert string to char");
            Console.WriteLine("float value = 23.45;     // Error: Cannot implicitly convert double to float");
            
            Console.WriteLine("\nFixed code:");
            Console.WriteLine("int number = 10;        // Removed quotes");
            Console.WriteLine("char letter = 'B';      // Changed double quotes to single quotes");
            Console.WriteLine("float value = 23.45f;   // Added 'f' suffix");
            
            // Actual fixed code
            int number = 10;        // Removed quotes
            char letter = 'B';      // Changed double quotes to single quotes
            float value = 23.45f;   // Added 'f' suffix
            
            Console.WriteLine("\nValues after fixing:");
            Console.WriteLine($"number: {number}");
            Console.WriteLine($"letter: {letter}");
            Console.WriteLine($"value: {value}");
        }
    }
}