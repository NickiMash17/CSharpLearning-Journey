// src/SectionC/Program.cs
using System;

namespace SectionC
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueRunning = true;

            while (continueRunning)
            {
                Console.Clear();
                Console.WriteLine("=== SECTION C: OPERATORS ===");
                Console.WriteLine("\nChoose an example:");
                Console.WriteLine("1. Arithmetic Operators");
                Console.WriteLine("2. Relational Operators");
                Console.WriteLine("3. Logical Operators");
                Console.WriteLine("4. Increment/Decrement Operators");
                Console.WriteLine("5. Bitwise Operators");
                Console.WriteLine("6. Bitwise Assignment Operators");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice (0-6): ");
                
                string choice = Console.ReadLine();
                Console.WriteLine();
                
                switch (choice)
                {
                    case "1":
                        ArithmeticOperators();
                        break;
                    case "2":
                        RelationalOperators();
                        break;
                    case "3":
                        LogicalOperators();
                        break;
                    case "4":
                        IncrementDecrementOperators();
                        break;
                    case "5":
                        BitwiseOperators();
                        break;
                    case "6":
                        BitwiseAssignmentOperators();
                        break;
                    case "0":
                        continueRunning = false;
                        Console.WriteLine("Returning to main menu...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
                
                if (continueRunning)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }
        
        static void ArithmeticOperators()
        {
            Console.WriteLine("=== Arithmetic Operators ===\n");
            
            int a = 10, b = 3;
            Console.WriteLine($"Given: a = {a}, b = {b}");
            Console.WriteLine($"Addition (a + b): {a + b}");
            Console.WriteLine($"Subtraction (a - b): {a - b}");
            Console.WriteLine($"Multiplication (a * b): {a * b}");
            Console.WriteLine($"Division (a / b): {a / b}");
            Console.WriteLine($"Modulus (a % b): {a % b}");
            
            // Example with floating-point division
            double x = 10.0, y = 3.0;
            Console.WriteLine($"\nFloat division (10.0 / 3.0): {x / y:F2}");
        }
        
        static void RelationalOperators()
        {
            Console.WriteLine("=== Relational Operators ===\n");
            
            int a = 5, b = 3;
            Console.WriteLine($"Given: a = {a}, b = {b}");
            Console.WriteLine($"Equal to (a == b): {a == b}");
            Console.WriteLine($"Not equal to (a != b): {a != b}");
            Console.WriteLine($"Greater than (a > b): {a > b}");
            Console.WriteLine($"Less than (a < b): {a < b}");
            Console.WriteLine($"Greater than or equal to (a >= b): {a >= b}");
            Console.WriteLine($"Less than or equal to (a <= b): {a <= b}");
        }
        
        static void LogicalOperators()
        {
            Console.WriteLine("=== Logical Operators ===\n");
            
            bool x = true, y = false;
            Console.WriteLine($"Given: x = {x}, y = {y}");
            Console.WriteLine($"AND (x && y): {x && y}");
            Console.WriteLine($"OR (x || y): {x || y}");
            Console.WriteLine($"NOT (!x): {!x}");
            
            // Short-circuit example
            Console.WriteLine("\nShort-circuit evaluation:");
            bool result = false && CheckValue(); // CheckValue() won't be called
            Console.WriteLine($"False && CheckValue(): {result}");
        }
        
        static bool CheckValue()
        {
            Console.WriteLine("This won't be printed due to short-circuiting");
            return true;
        }
        
        static void IncrementDecrementOperators()
        {
            Console.WriteLine("=== Increment/Decrement Operators ===\n");
            
            int i = 5;
            Console.WriteLine($"Initial value: i = {i}");
            
            Console.WriteLine($"Pre-increment (++i): {++i}");
            Console.WriteLine($"Current value: {i}");
            
            Console.WriteLine($"Post-increment (i++): {i++}");
            Console.WriteLine($"Current value: {i}");
            
            Console.WriteLine($"Pre-decrement (--i): {--i}");
            Console.WriteLine($"Current value: {i}");
            
            Console.WriteLine($"Post-decrement (i--): {i--}");
            Console.WriteLine($"Final value: {i}");
        }
        
        static void BitwiseOperators()
        {
            Console.WriteLine("=== Bitwise Operators ===\n");
            
            int a = 12;  // 1100 in binary
            int b = 10;  // 1010 in binary
            
            Console.WriteLine($"Given: a = {a} (binary: {Convert.ToString(a, 2).PadLeft(4, '0')})");
            Console.WriteLine($"       b = {b} (binary: {Convert.ToString(b, 2).PadLeft(4, '0')})");
            
            Console.WriteLine($"Bitwise AND (a & b): {a & b} (binary: {Convert.ToString(a & b, 2).PadLeft(4, '0')})");
            Console.WriteLine($"Bitwise OR (a | b): {a | b} (binary: {Convert.ToString(a | b, 2).PadLeft(4, '0')})");
            Console.WriteLine($"Bitwise XOR (a ^ b): {a ^ b} (binary: {Convert.ToString(a ^ b, 2).PadLeft(4, '0')})");
            Console.WriteLine($"Bitwise NOT (~a): {~a} (binary: {Convert.ToString(~a, 2)})");
            Console.WriteLine($"Left Shift (a << 1): {a << 1} (binary: {Convert.ToString(a << 1, 2)})");
            Console.WriteLine($"Right Shift (a >> 1): {a >> 1} (binary: {Convert.ToString(a >> 1, 2)})");
        }
        
        static void BitwiseAssignmentOperators()
        {
            Console.WriteLine("=== Bitwise Assignment Operators ===\n");
            
            int x = 12;  // 1100 in binary
            Console.WriteLine($"Initial value: x = {x} (binary: {Convert.ToString(x, 2).PadLeft(4, '0')})");
            
            x &= 10;  // AND assignment
            Console.WriteLine($"After AND assignment (&=): {x} (binary: {Convert.ToString(x, 2).PadLeft(4, '0')})");
            
            x |= 6;   // OR assignment
            Console.WriteLine($"After OR assignment (|=): {x} (binary: {Convert.ToString(x, 2).PadLeft(4, '0')})");
            
            x ^= 3;   // XOR assignment
            Console.WriteLine($"After XOR assignment (^=): {x} (binary: {Convert.ToString(x, 2).PadLeft(4, '0')})");
            
            x <<= 2;  // Left shift assignment
            Console.WriteLine($"After left shift assignment (<<=): {x} (binary: {Convert.ToString(x, 2)})");
            
            x >>= 1;  // Right shift assignment
            Console.WriteLine($"After right shift assignment (>>=): {x} (binary: {Convert.ToString(x, 2)})");
        }
    }
}