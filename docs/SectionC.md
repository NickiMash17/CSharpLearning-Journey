# Section C: Operators 🔧

C# provides a rich set of operators for performing operations on variables and values. Understanding these operators is essential for writing efficient code.

## 📚 Types of Operators

### 1. Arithmetic Operators
Basic mathematical operations:

```csharp
int a = 10, b = 3;
Console.WriteLine($"Addition: {a + b}");        // 13
Console.WriteLine($"Subtraction: {a - b}");     // 7
Console.WriteLine($"Multiplication: {a * b}");  // 30
Console.WriteLine($"Division: {a / b}");        // 3
Console.WriteLine($"Modulus: {a % b}");         // 1
```

### 2. Relational Operators
Compare values:

```csharp
int x = 5, y = 10;
Console.WriteLine($"Equal to: {x == y}");           // False
Console.WriteLine($"Not equal to: {x != y}");       // True
Console.WriteLine($"Greater than: {x > y}");        // False
Console.WriteLine($"Less than: {x < y}");           // True
Console.WriteLine($"Greater or equal: {x >= y}");   // False
Console.WriteLine($"Less or equal: {x <= y}");      // True
```

### 3. Logical Operators
Combine boolean expressions:

```csharp
bool isValid = true;
bool isComplete = false;

Console.WriteLine($"AND: {isValid && isComplete}");  // False
Console.WriteLine($"OR: {isValid || isComplete}");   // True
Console.WriteLine($"NOT: {!isValid}");              // False
```

### 4. Increment/Decrement Operators
Change value by 1:

```csharp
int counter = 5;
Console.WriteLine($"Pre-increment: {++counter}");   // 6
Console.WriteLine($"Post-increment: {counter++}");  // 6 (then 7)
Console.WriteLine($"Pre-decrement: {--counter}");   // 6
Console.WriteLine($"Post-decrement: {counter--}");  // 6 (then 5)
```

### 5. Bitwise Operators
Manipulate individual bits:

```csharp
int a = 12;  // 1100 in binary
int b = 10;  // 1010 in binary

Console.WriteLine($"AND: {a & b}");   // 8  (1000)
Console.WriteLine($"OR: {a | b}");    // 14 (1110)
Console.WriteLine($"XOR: {a ^ b}");   // 6  (0110)
Console.WriteLine($"NOT: {~a}");      // -13
Console.WriteLine($"Left Shift: {a << 1}");   // 24 (11000)
Console.WriteLine($"Right Shift: {a >> 1}");  // 6  (0110)
```

## 🎯 Special Operators

### 1. Null-Coalescing Operator (??)
```csharp
string name = null;
string displayName = name ?? "Anonymous";  // "Anonymous"
```

### 2. Conditional Operator (? :)
```csharp
int age = 20;
string status = (age >= 18) ? "Adult" : "Minor";
```

### 3. Null-Conditional Operator (?)
```csharp
string? text = null;
int? length = text?.Length;  // null instead of NullReferenceException
```

## 💡 Best Practices

1. **Operator Precedence**
```csharp
// Use parentheses for clarity
int result = (a + b) * c;  // Better than: a + b * c
```

2. **Short-Circuit Evaluation**
```csharp
if (obj != null && obj.Value > 0)  // Null check first
{
    // Safe to access obj.Value
}
```

## 🚨 Common Pitfalls

1. **Integer Division**
```csharp
double result = 5 / 2;     // 2.0 (not 2.5)
double correct = 5.0 / 2;  // 2.5 (correct)
```

2. **Increment/Decrement Order**
```csharp
int x = 5;
Console.WriteLine(x++);  // Prints 5, then x becomes 6
Console.WriteLine(++x);  // x becomes 7, then prints 7
```

## 🎓 Practice Exercises

1. Implement calculator operations
2. Work with bitwise flags
3. Practice operator precedence
4. Use conditional operators
5. Handle null values safely

## 📝 Notes

- Be careful with operator precedence
- Use parentheses for clarity
- Remember short-circuit evaluation
- Consider overflow possibilities
- Test edge cases

---

Next: [Challenges](Challenges.md) ➡️