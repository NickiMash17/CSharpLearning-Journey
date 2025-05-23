using System;

namespace SectionD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Loops Learning Activities ===\n");
            
            // Display menu for different activities
            while (true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        LoopDiscoveryDemo();
                        break;
                    case "2":
                        BeginnerPractice();
                        break;
                    case "3":
                        LoopChallenges();
                        break;
                    case "4":
                        Console.WriteLine("Thanks for learning about loops! Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }
                
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        
        static void DisplayMenu()
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Loop Discovery Demo (for, while, do-while)");
            Console.WriteLine("2. Beginner Practice Tasks");
            Console.WriteLine("3. Loop Challenges");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");
        }
        
        static void LoopDiscoveryDemo()
        {
            Console.Clear();
            Console.WriteLine("=== LOOP DISCOVERY DEMO ===\n");
            
            Console.WriteLine("=== FOR loop ===");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("FOR loop - i is: " + i);
            }
            
            Console.WriteLine("\n=== WHILE loop ===");
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("WHILE loop - count is: " + count);
                count++;
            }
            
            Console.WriteLine("\n=== DO-WHILE loop ===");
            int number = 0;
            do
            {
                Console.WriteLine("DO-WHILE loop - number is: " + number);
                number++;
            }
            while (number < 5);
            
            Console.WriteLine("\n=== EXPLORATION DEMO ===");
            Console.WriteLine("Modified FOR loop (1 to 10):");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Modified FOR - i is: " + i);
            }
            
            Console.WriteLine("\nModified DO-WHILE loop (10 to 1):");
            int countdown = 10;
            do
            {
                Console.WriteLine("Countdown: " + countdown);
                countdown--;
            }
            while (countdown >= 1);
        }
        
        static void BeginnerPractice()
        {
            Console.Clear();
            Console.WriteLine("=== BEGINNER PRACTICE TASKS ===\n");
            
            while (true)
            {
                Console.WriteLine("Choose an exercise:");
                Console.WriteLine("1. Count Up (1 to 10)");
                Console.WriteLine("2. Only Even Numbers (2 to 20)");
                Console.WriteLine("3. Number Guessing Game");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");
                
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        Exercise_CountUp();
                        break;
                    case "2":
                        Exercise_EvenNumbers();
                        break;
                    case "3":
                        Exercise_NumberGuessing();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.\n");
                        continue;
                }
                
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.WriteLine();
            }
        }
        
        static void Exercise_CountUp()
        {
            Console.WriteLine("\n=== Exercise 1: Count Up ===");
            Console.WriteLine("Printing numbers from 1 to 10:");
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        static void Exercise_EvenNumbers()
        {
            Console.WriteLine("\n=== Exercise 2: Only Even Numbers ===");
            Console.WriteLine("Even numbers between 2 and 20:");
            
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        
        static void Exercise_NumberGuessing()
        {
            Console.WriteLine("\n=== Exercise 3: Number Guessing Game ===");
            int secretNumber = 7;
            int guess;
            
            Console.WriteLine("I'm thinking of a number between 1 and 10...");
            
            do
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out guess))
                {
                    if (guess == secretNumber)
                    {
                        Console.WriteLine("Correct! 🎉");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
            while (true);
        }
        
        static void LoopChallenges()
        {
            Console.Clear();
            Console.WriteLine("=== LOOP CHALLENGES ===\n");
            
            while (true)
            {
                Console.WriteLine("Choose a challenge:");
                Console.WriteLine("1. Print a Star Triangle");
                Console.WriteLine("2. Find a Prime Number");
                Console.WriteLine("3. Simple Menu System");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("Enter your choice: ");
                
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        Challenge_StarTriangle();
                        break;
                    case "2":
                        Challenge_PrimeNumber();
                        break;
                    case "3":
                        Challenge_MenuSystem();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.\n");
                        continue;
                }
                
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.WriteLine();
            }
        }
        
        static void Challenge_StarTriangle()
        {
            Console.WriteLine("\n=== Challenge 1: Star Triangle ===");
            Console.Write("Enter the number of rows: ");
            
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Console.WriteLine($"Star triangle with {n} rows:");
                
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive number.");
            }
        }
        
        static void Challenge_PrimeNumber()
        {
            Console.WriteLine("\n=== Challenge 2: Find a Prime Number ===");
            Console.WriteLine("Keep entering numbers until you enter a prime number!");
            
            while (true)
            {
                Console.Write("Enter a number: ");
                
                if (int.TryParse(Console.ReadLine(), out int number) && number > 1)
                {
                    if (IsPrime(number))
                    {
                        Console.WriteLine("Prime number accepted! 🎉");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{number} is not a prime number. Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number greater than 1.");
                }
            }
        }
        
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;
            
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }
        
        static void Challenge_MenuSystem()
        {
            Console.WriteLine("\n=== Challenge 3: Simple Menu System ===");
            
            while (true)
            {
                Console.WriteLine("\n--- Fun Menu ---");
                Console.WriteLine("1. Greet Me");
                Console.WriteLine("2. Show Me a Fun Fact");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Hello there! Nice to meet you! 👋");
                        break;
                    case "2":
                        ShowRandomFact();
                        break;
                    case "3":
                        Console.WriteLine("Thanks for using the menu system! Goodbye! 👋");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                        break;
                }
            }
        }
        
        static void ShowRandomFact()
        {
            string[] facts = {
                "Did you know? Octopuses have three hearts! 🐙",
                "Fun fact: Honey never spoils - archaeologists have found edible honey in ancient Egyptian tombs! 🍯",
                "Amazing! A group of flamingos is called a 'flamboyance'! 🦩",
                "Cool fact: Bananas are berries, but strawberries aren't! 🍌",
                "Incredible: The shortest war in history lasted only 38-45 minutes! ⚔️"
            };
            
            Random random = new Random();
            int index = random.Next(facts.Length);
            Console.WriteLine(facts[index]);
        }
    }
}