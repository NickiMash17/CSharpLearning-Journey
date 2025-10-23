// src/Challenges/Program.cs
using System;

namespace Challenges
{
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
        */

        // Exercise 1: Circle Class
        Console.WriteLine("--- Circle Class ---");
        Circle circle = new Circle();
        circle.Radius = 5;
        Console.WriteLine($"Circle (Radius: {circle.Radius})");
        Console.WriteLine($"Area: {circle.GetArea():F2}");
        Console.WriteLine($"Circumference: {circle.GetCircumference():F2}");

        Console.WriteLine("\nAttempting to set radius to a negative value...");
        circle.Radius = -7;
        Console.WriteLine($"Circle Radius is now: {circle.Radius}");
        Console.WriteLine();

        // Exercise 2: Product Class
        Console.WriteLine("--- Product Class ---");
        Product product = new Product("Laptop", 1200.50m, 10);
        Console.WriteLine($"Product: {product.Name}, Price: {product.Price:C}, Quantity: {product.Quantity}");
        Console.WriteLine($"Total Value: {product.CalculateTotalValue():C}");

        Console.WriteLine();

        // Exercise 3: Smart Home System (OOP Demonstration)
        Console.WriteLine("--- Smart Home System ---");

        // Create different appliances
        Light livingRoomLight = new Light("Philips", "Hue Bulb");
        Speaker kitchenSpeaker = new Speaker("Sonos", "One");
        Thermostat mainThermostat = new Thermostat("Nest", "Thermostat");

        // Store appliances in a list for polymorphism demonstration
        List<IControllable> appliances = new List<IControllable>
        {
            livingRoomLight,
            kitchenSpeaker,
            mainThermostat
        };

        // Display initial status
        Console.WriteLine("Initial appliance statuses:");
        foreach (var appliance in appliances)
        {
            Console.WriteLine(appliance.ToString());
        }

        Console.WriteLine("\nDemonstrating polymorphism - controlling all appliances:");

        // Turn all appliances on
        foreach (var appliance in appliances)
        {
            appliance.TurnOn();
        }

        Console.WriteLine("\nPerforming unique actions for each appliance:");

        // Perform unique actions (polymorphism in action)
        livingRoomLight.PerformAction(); // Adjust brightness
        kitchenSpeaker.PerformAction();  // Play music
        mainThermostat.PerformAction();  // Adjust temperature

        Console.WriteLine("\nFinal appliance statuses:");
        foreach (var appliance in appliances)
        {
            Console.WriteLine(appliance.ToString());
        }

        // Turn off all appliances
        Console.WriteLine("\nTurning off all appliances:");
        foreach (var appliance in appliances)
        {
            appliance.TurnOff();
        }

        // --- OOP Exercises ---

        // Exercise 1: Class Hierarchy
        public class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }

            public virtual string Describe()
            {
                return $"This vehicle is a {Make} {Model}.";
            }
        }

        public class Car : Vehicle, IDrivable
        {
            public int NumberOfDoors { get; set; }

            public override string Describe()
            {
                return $"This car is a {Make} {Model} with {NumberOfDoors} doors.";
            }

            public void Drive()
            {
                Console.WriteLine($"Driving the car: {Make} {Model}");
            }
        }

        public class Motorcycle : Vehicle, IDrivable
        {
            public bool HasSidecar { get; set; }

            public override string Describe()
            {
                return $"This motorcycle is a {Make} {Model}" +
                       (HasSidecar ? " with a sidecar." : " without a sidecar.");
            }

            public void Drive()
            {
                Console.WriteLine($"Riding the motorcycle: {Make} {Model}");
            }
        }

        // Exercise 2: Interface Implementation
        public interface IDrivable
        {
            void Drive();
        }

        // Exercise 3: Abstract Class
        public abstract class Employee
        {
            public string Name { get; set; }
            public abstract decimal CalculatePay();
        }

        public class HourlyEmployee : Employee
        {
            public decimal HourlyRate { get; set; }
            public int HoursWorked { get; set; }

            public override decimal CalculatePay()
            {
                return HourlyRate * HoursWorked;
            }
        }

        public class SalariedEmployee : Employee
        {
            public decimal MonthlySalary { get; set; }

            public override decimal CalculatePay()
            {
                return MonthlySalary;
            }
        }

        // Exercise 4: ToString() Practice
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }

            public override string ToString()
            {
                return $"{Title} by {Author} ({Year})";
            }
        }

        // --- Demo code for the exercises ---
        Console.WriteLine("\n--- OOP Exercises ---");

        // Exercise 1 & 2 Demo
        Car car = new Car { Make = "Toyota", Model = "Corolla", NumberOfDoors = 4 };
        Motorcycle motorcycle = new Motorcycle { Make = "Harley", Model = "Street 750", HasSidecar = true };

        Console.WriteLine(car.Describe());
        Console.WriteLine(motorcycle.Describe());

        List<IDrivable> drivables = new List<IDrivable> { car, motorcycle };
        Console.WriteLine("\nDriving all vehicles:");
        foreach (var d in drivables)
        {
            d.Drive();
        }

        // Exercise 3 Demo
        HourlyEmployee hourly = new HourlyEmployee { Name = "Alice", HourlyRate = 20m, HoursWorked = 160 };
        SalariedEmployee salaried = new SalariedEmployee { Name = "Bob", MonthlySalary = 5000m };

        Console.WriteLine($"\n{hourly.Name}'s pay: {hourly.CalculatePay():C}");
        Console.WriteLine($"{salaried.Name}'s pay: {salaried.CalculatePay():C}");

        // Exercise 4 Demo
        List<Book> books = new List<Book>
        {
            new Book { Title = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 },
            new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 }
        };

        Console.WriteLine("\nBooks:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}
}
