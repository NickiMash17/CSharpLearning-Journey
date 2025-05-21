// src/Challenges/Calculator.cs
using System;

namespace Challenges
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULATOR CHALLENGE ===");
            
            // Get first number
            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double firstNumber))
            {
                Console.WriteLine("Invalid input. Using default value of 10.");
                firstNumber = 10;
            }
            
            // Get second number
            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double secondNumber))
            {
                Console.WriteLine("Invalid input. Using default value of 5.");
                secondNumber = 5;
            }
            
            // Display operation menu
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("+ : Addition");
            Console.WriteLine("- : Subtraction");
            Console.WriteLine("* : Multiplication");
            Console.WriteLine("/ : Division");
            Console.WriteLine("% : Modulus (Remainder)");
            
            // Get operation choice
            Console.Write("\nEnter your choice: ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to next line after key press
            
            // Calculate result using switch-case
            double result = 0;
            bool validOperation = true;
            
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    // Check for division by zero
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("\nError: Cannot divide by zero");
                        validOperation = false;
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                    }
                    break;
                case '%':
                    // Check for modulus by zero
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("\nError: Cannot calculate modulus with zero");
                        validOperation = false;
                    }
                    else
                    {
                        result = firstNumber % secondNumber;
                    }
                    break;
                default:
                    Console.WriteLine("\nError: Invalid operation selected");
                    validOperation = false;
                    break;
            }
            
            // Display result if operation was valid
            if (validOperation)
            {
                Console.WriteLine($"\nResult: {firstNumber} {operation} {secondNumber} = {result}");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
