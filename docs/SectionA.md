# Section A: Variable Scope 🎯

Variable scope determines where variables can be accessed in your code. Understanding scope is crucial for writing maintainable and bug-free C# programs.

## 📚 Key Concepts

### 1. Local Variables
Variables declared inside a method or block that are only accessible within that scope.

```csharp
void ExampleMethod()
{
    int localVar = 5;  // Only accessible within ExampleMethod
    Console.WriteLine(localVar);  // Works here
}

void AnotherMethod()
{
    // Console.WriteLine(localVar);  // Error! localVar not accessible here
}
```

### 2. Class-Level Variables
Variables declared at the class level that are accessible throughout the class.

```csharp
public class Example
{
    private int classVar = 10;  // Accessible throughout the class
    
    void Method1()
    {
        Console.WriteLine(classVar);  // Works here
    }
    
    void Method2()
    {
        classVar = 20;  // Also works here
    }
}
```

### 3. Block Scope
Variables declared within code blocks (inside curly braces) are only accessible within that block.

```csharp
if (true)
{
    int blockVar = 15;  // Only accessible within this if block
    Console.WriteLine(blockVar);  // Works here
}
// Console.WriteLine(blockVar);  // Error! blockVar not accessible here
```

### 4. Method Parameters
Parameters are variables that receive values when a method is called.

```csharp
void Add(int x, int y)  // x and y are parameters
{
    int sum = x + y;    // x and y accessible within method
    Console.WriteLine($"Sum: {sum}");
}
```

## 🎓 Examples

### Variable Shadowing
When a local variable has the same name as a class-level variable:

```csharp
public class ShadowExample
{
    private string message = "Class level";
    
    void PrintMessage()
    {
        string message = "Local level";  // Shadows class variable
        Console.WriteLine(message);      // Prints "Local level"
        Console.WriteLine(this.message); // Prints "Class level"
    }
}
```

### Scope in Loops
Variables declared in loop structures:

```csharp
for (int i = 0; i < 5; i++)  // i only exists within the loop
{
    int square = i * i;      // square only exists within loop block
    Console.WriteLine(square);
}
// i and square are not accessible here
```

## 🚀 Best Practices

1. **Minimize Scope**: Keep variable scope as narrow as possible
2. **Clear Names**: Use descriptive variable names
3. **Avoid Shadowing**: Don't use the same name for different scope levels
4. **Initialize Early**: Declare variables close to their first use
5. **Use Access Modifiers**: Properly control access to class members

## 🎯 Practice Exercises

1. Create a class with both local and class-level variables
2. Implement a method demonstrating variable shadowing
3. Write code showing different block scope scenarios
4. Create methods with various parameter types

## 🔍 Common Pitfalls

- Accessing variables outside their scope
- Unintentional variable shadowing
- Forgetting to initialize variables
- Using overly broad scope for variables

## 📝 Notes

- Variables should be declared in the smallest possible scope
- Class-level variables should only be used when necessary
- Consider using properties instead of public fields
- Be careful with variable shadowing as it can lead to confusion

---

Next: [Section B: Data Types](SectionB.md) ➡️