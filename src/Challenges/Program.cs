// src/Challenges/Calculator.cs
using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        // Exercise 1: Student Class
        Console.WriteLine("--- Student Class ---");
        Student student1 = new Student { ID = 1, Major = "Computer Science", GPA = 3.8 };
        Console.WriteLine($"Student 1 ({student1.Major}) GPA is {student1.GPA}. On honor roll: {student1.IsHonorRoll()}");

        Student student2 = new Student { ID = 2, Major = "History", GPA = 3.2 };
        Console.WriteLine($"Student 2 ({student2.Major}) GPA is {student2.GPA}. On honor roll: {student2.IsHonorRoll()}");

        Console.WriteLine();

        // Exercise 2: Rectangle Class
        Console.WriteLine("--- Rectangle Class ---");
        Rectangle rectangle = new Rectangle();
        rectangle.Length = 5;
        rectangle.Width = 10;
        Console.WriteLine($"Rectangle (Length: {rectangle.Length}, Width: {rectangle.Width})");
        Console.WriteLine($"Area: {rectangle.GetArea()}");
        Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}");

        // Test encapsulation by trying to set a negative value
        Console.WriteLine("\nAttempting to set length to a negative value...");
        rectangle.Length = -5;
        Console.WriteLine($"Rectangle Length is now: {rectangle.Length}");

        Console.WriteLine();
        */
        
        // Exercise 3: User Account Class (Interactive Version)
        Console.WriteLine("--- User Account Class ---");
        UserAccount user = new UserAccount("Nicolette", "Password123");

        // --- Interactive Login with Retry ---
        bool isLoggedIn = false;
        while (!isLoggedIn)
        {
            Console.WriteLine("\nPlease enter the password to log in:");
            string? inputPassword = Console.ReadLine();

            // The Login method will return true or false
            isLoggedIn = user.Login(inputPassword ?? "");

            if (!isLoggedIn)
            {
                Console.WriteLine("Login failed. Please check your password and try again.");
            }
        }

        Console.WriteLine("Welcome, Nicolette!");
    }
}