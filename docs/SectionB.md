# Section B: Data Types 📊

Understanding data types is fundamental to C# programming. C# is a strongly-typed language, meaning every variable must have a specific type.

## 📚 Core Data Types

### 1. Value Types
Stored directly in memory, contain their data:

```csharp
// Numeric Types
int wholeNumber = 42;           // 32-bit integer
long bigNumber = 9876543210L;   // 64-bit integer
float decimal1 = 3.14f;         // 32-bit floating-point
double decimal2 = 3.14159;      // 64-bit floating-point
decimal money = 99.99m;         // 128-bit precise decimal

// Other Value Types
bool flag = true;               // Boolean true/false
char letter = 'A';              // Single Unicode character
```

### 2. Reference Types
Store references to data in memory:

```csharp
string text = "Hello, World!";  // String of characters
object obj = new object();      // Base type for all types
int[] numbers = {1, 2, 3};      // Array (reference type)
```

## 🔄 Type Conversion

### Implicit Conversion (Safe)
```csharp
int num = 100;
long bigNum = num;      // int fits inside long
float f = bigNum;       // long fits inside float
```

### Explicit Conversion (Casting)
```csharp
double pi = 3.14159;
int rounded = (int)pi;  // Loses decimal portion
```

### Using Convert Class
```csharp
string numberText = "123";
int parsedNum = Convert.ToInt32(numberText);
bool parsedBool = Convert.ToBoolean("True");
```

## 🎯 Common Scenarios

### 1. Working with Numbers
```csharp
// Integer division
int result = 5 / 2;        // Result: 2 (truncated)
double accurate = 5.0 / 2; // Result: 2.5 (floating-point)

// Overflow checking
checked
{
    int max = int.MaxValue;
    // int overflow = max + 1; // Throws OverflowException
}
```

### 2. String Operations
```csharp
string name = "Alice";
int age = 25;
string message = $"Hello, {name}! You are {age} years old.";
```

## 🚨 Common Pitfalls

1. **Integer Division**
```csharp
int x = 5 / 2;          // Results in 2, not 2.5
double y = 5.0 / 2;     // Results in 2.5 (correct)
```

2. **Floating-Point Precision**
```csharp
decimal financial = 0.1m + 0.2m;  // Precise: 0.3
double scientific = 0.1 + 0.2;    // Imprecise: 0.30000000000000004
```

## 💡 Best Practices

1. **Choose Appropriate Types**
- Use `int` for whole numbers
- Use `decimal` for financial calculations
- Use `double` for scientific calculations
- Use `bool` for true/false conditions

2. **Safe Type Conversion**
```csharp
string input = "123";
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Parsed: {number}");
}
else
{
    Console.WriteLine("Invalid number");
}
```

## 🎓 Practice Exercises

1. Create variables of each basic type
2. Perform various type conversions
3. Handle numeric overflow scenarios
4. Work with string formatting
5. Implement safe parsing with error handling

## 📝 Notes

- Always initialize variables before use
- Use appropriate numeric types for calculations
- Be careful with floating-point comparisons
- Consider memory usage when choosing types
- Use nullable types when values might be missing

---

Next: [Section C: Operators](SectionC.md) ➡️