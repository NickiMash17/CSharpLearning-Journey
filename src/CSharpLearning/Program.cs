using System;
using System.Diagnostics;

namespace CSharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            
            while (!exitProgram)
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("=== C# LEARNING JOURNEY PROGRAM ===");
                Console.WriteLine("===================================");
                Console.WriteLine("\nChoose a section to explore:");
                Console.WriteLine("1. Section A: Variable Scope");
                Console.WriteLine("2. Section B: Data Types");
                Console.WriteLine("3. Section C: Operators");
                Console.WriteLine("4. Section D: Loops");
                Console.WriteLine("5. Challenge: Calculator Program");
                Console.WriteLine("0. Exit Program");
                Console.Write("\nEnter your choice (0-5): ");
                
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        RunProgram("SectionA");
                        break;
                    case "2":
                        RunProgram("SectionB");
                        break;
                    case "3":
                        RunProgram("SectionC");
                        break;
                    case "4":
                        RunProgram("SectionD");
                        break;
                    case "5":
                        RunProgram("Challenges");
                        break;
                    case "0":
                        exitProgram = true;
                        Console.WriteLine("\nThank you for using the C# Learning Program!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice! Please try again.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        
        static void RunProgram(string projectName)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = $"run --project src/{projectName}/{projectName}.csproj",
                    UseShellExecute = false
                };
                
                Process process = new Process { StartInfo = startInfo };
                process.Start();
                process.WaitForExit();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError running {projectName}: {ex.Message}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
