/*
 * Simple Banking System
 * My Implementation of a basic banking application with:
 * - Account balance management
 * - Secure money deposits with limits
 * - Validated withdrawals with balance checks
 * - Robust error handling for user inputs
 * 
 * Created by: Nicolette Mashaba
 * Date: May 23, 2025
 */

using System;

namespace CSharpLearning.SectionD.BankingSystem
{
    public class BankingSystemDemo
    {
        private const double INITIAL_BALANCE = 1000.00;
        private double _balance;

        public BankingSystemDemo()
        {
            _balance = INITIAL_BALANCE;
        }

        public static void Run()
        {
            var bankingSystem = new BankingSystemDemo();
            bankingSystem.StartBankingSystem();
        }

        private void StartBankingSystem()
        {
            bool exitProgram = false;
            
            DisplayWelcomeMessage();
            
            while (!exitProgram)
            {
                try
                {
                    // Display enhanced menu options
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("┌────────────────────────────────────────┐");
                    Console.WriteLine("│            MAIN MENU OPTIONS           │");
                    Console.WriteLine("└────────────────────────────────────────┘");
                    Console.ResetColor();
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  1. 💰 Check Balance");
                    Console.WriteLine("  2. 📈 Deposit Money");
                    Console.WriteLine("  3. 📉 Withdraw Money");
                    Console.WriteLine("  4. 🚪 Exit");
                    Console.ResetColor();
                    
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("👉 Enter your choice (1-4): ");
                    Console.ResetColor();
                    
                    // Read user's choice
                    string input = Console.ReadLine() ?? "";
                    int choice;
                    
                    // Try to parse the input as an integer
                    if (!int.TryParse(input, out choice))
                    {
                        throw new FormatException("Invalid input. Please enter a number between 1 and 4.");
                    }
                    
                    Console.WriteLine();
                    
                    // Process the user's choice using if...else statements
                    if (choice == 1)
                    {
                        // Check Balance
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("💰 ═══════ BALANCE INQUIRY ═══════");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"   Current Balance: ${_balance:F2}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("═══════════════════════════════════");
                        Console.ResetColor();
                    }
                    else if (choice == 2)
                    {
                        // Deposit Money
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("📈 ═══════ DEPOSIT TRANSACTION ═══════");
                        Console.ResetColor();
                        Console.Write("💵 Enter deposit amount: $");
                        string depositInput = Console.ReadLine() ?? "";
                        double depositAmount;
                        
                        if (!double.TryParse(depositInput, out depositAmount))
                        {
                            throw new FormatException("Invalid amount. Please enter a numeric value.");
                        }
                        
                        // Validate deposit amount
                        if (depositAmount <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("❌ Error: Deposit amount must be positive.");
                            Console.ResetColor();
                        }
                        else
                        {
                            // Update balance and display confirmation
                            _balance += depositAmount;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"✅ Deposit successful. New balance: ${_balance:F2}");
                            Console.WriteLine("═══════════════════════════════════════");
                            Console.ResetColor();
                        }
                    }
                    else if (choice == 3)
                    {
                        // Withdraw Money
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("📉 ═══════ WITHDRAWAL TRANSACTION ═══════");
                        Console.ResetColor();
                        Console.Write("💸 Enter withdrawal amount: $");
                        string withdrawInput = Console.ReadLine() ?? "";
                        double withdrawAmount;
                        
                        if (!double.TryParse(withdrawInput, out withdrawAmount))
                        {
                            throw new FormatException("Invalid amount. Please enter a numeric value.");
                        }
                        
                        // Validate withdrawal amount
                        if (withdrawAmount <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("❌ Error: Withdrawal amount must be positive.");
                            Console.ResetColor();
                        }
                        else if (withdrawAmount > _balance)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("❌ Error: Insufficient funds. Withdrawal amount exceeds current balance.");
                            Console.ResetColor();
                        }
                        else
                        {
                            // Update balance and display confirmation
                            _balance -= withdrawAmount;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"✅ Withdrawal successful. New balance: ${_balance:F2}");
                            Console.WriteLine("═══════════════════════════════════════");
                            Console.ResetColor();
                        }
                    }
                    else if (choice == 4)
                    {
                        // Exit the program
                        exitProgram = true;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("🚪 ═══════════════════════════════════════");
                        Console.WriteLine("   Thank you for using Simple Banking System");
                        Console.WriteLine("              👋 Goodbye! 👋");
                        Console.WriteLine("═══════════════════════════════════════");
                        Console.ResetColor();
                    }
                    else
                    {
                        // Handle invalid menu selection
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("❌ Error: Invalid selection. Please enter a number between 1 and 4.");
                        Console.ResetColor();
                    }
                }
                catch (FormatException ex)
                {
                    // Handle format errors (non-numeric inputs)
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"❌ Error: {ex.Message}");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    // Handle any other unexpected errors
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"⚠️  Unexpected error occurred: {ex.Message}");
                    Console.WriteLine("Please try again.");
                    Console.ResetColor();
                }
                
                // Add spacing between operations
                if (!exitProgram)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Press any key to continue...");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    
                    // Redisplay header
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("╔══════════════════════════════════════════╗");
                    Console.WriteLine("║        🏦 SIMPLE BANKING SYSTEM 🏦        ║");
                    Console.WriteLine("╚══════════════════════════════════════════╝");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }

        private void DisplayWelcomeMessage()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔══════════════════════════════════════════╗");
            Console.WriteLine("║        🏦 SIMPLE BANKING SYSTEM 🏦        ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}

/* 
 * Developed and maintained by me (Nicolette Mashaba)
 * Last update: June 04, 2025
 * Contact: nene171408@gmail.com
 */