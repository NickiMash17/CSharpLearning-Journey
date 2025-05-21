# Programming Challenges 🏆

Practice your C# skills with these hands-on programming challenges. Each challenge builds upon concepts learned in previous sections.

## 🧮 Challenge 1: Calculator Program

### Requirements
Create a console calculator that can:
- Perform basic arithmetic operations (+, -, *, /)
- Handle decimal numbers
- Prevent division by zero
- Allow continuous calculations
- Provide clear error messages

### Example Implementation
```csharp
public class Calculator
{
    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero!");
        return a / b;
    }
}
```

### Usage Example
```csharp
Calculator calc = new Calculator();
try
{
    Console.WriteLine("Enter first number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("Enter operation (+, -, *, /): ");
    string op = Console.ReadLine();
    
    Console.WriteLine("Enter second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());
    
    double result = op switch
    {
        "+" => calc.Add(num1, num2),
        "-" => calc.Subtract(num1, num2),
        "*" => calc.Multiply(num1, num2),
        "/" => calc.Divide(num1, num2),
        _ => throw new ArgumentException("Invalid operator")
    };
    
    Console.WriteLine($"Result: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

## 🎯 Additional Challenges

### Challenge 2: Temperature Converter
Create a program that converts between Celsius and Fahrenheit:
- Accept temperature input
- Allow user to choose direction of conversion
- Display formatted result
- Handle invalid inputs

### Challenge 3: Number Guessing Game
Implement a number guessing game:
- Generate random number between 1-100
- Track number of guesses
- Provide "higher/lower" hints
- Allow multiple rounds
- Keep score

### Challenge 4: String Manipulator
Build a string manipulation tool:
- Count characters
- Reverse string
- Check palindrome
- Convert case (upper/lower)
- Remove spaces

## 🌟 Bonus Challenges

### Advanced Calculator Features
Add these features to your calculator:
- Memory functions (M+, M-, MR, MC)
- Scientific operations (power, square root)
- History of calculations
- Support for parentheses

### Unit Testing
Write unit tests for your calculator:
```csharp
[TestClass]
public class CalculatorTests
{
    private Calculator _calculator;
    
    [TestInitialize]
    public void Setup()
    {
        _calculator = new Calculator();
    }
    
    [TestMethod]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        double a = 5, b = 3;
        
        // Act
        double result = _calculator.Add(a, b);
        
        // Assert
        Assert.AreEqual(8, result);
    }
    
    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Divide_ByZero_ThrowsException()
    {
        _calculator.Divide(5, 0);
    }
}
```

## 📝 Evaluation Criteria

Your solutions will be evaluated based on:
1. Code organization and clarity
2. Error handling
3. User interface design
4. Code efficiency
5. Test coverage
6. Documentation

## 🚀 Getting Started

1. Create a new project for each challenge
2. Plan your solution before coding
3. Write tests first (TDD approach)
4. Implement the solution
5. Refactor and optimize
6. Document your code

## 💡 Tips

- Break down complex problems into smaller tasks
- Use appropriate data types
- Validate all user inputs
- Follow C# naming conventions
- Comment your code appropriately
- Handle edge cases
- Write clear error messages

---

🎉 Congratulations on completing the C# Learning Journey! 