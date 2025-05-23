# Section D: Loops in C#

## Overview
This section covers the fundamental loop structures in C#: `for`, `while`, and `do-while` loops. Through hands-on activities and challenges, you'll master iteration and repetitive operations in C#.

## Learning Objectives
- Understand the three main loop types in C#
- Know when to use each loop type appropriately
- Practice common loop patterns and techniques
- Build interactive programs using loops

## Loop Types Covered

### 1. For Loop
- **Best for**: When you know the exact number of iterations
- **Structure**: Initialization, condition, increment/decrement in one line
- **Use cases**: Counting, iterating through collections with indices

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}
```

### 2. While Loop
- **Best for**: When the number of iterations depends on a condition
- **Structure**: Condition checked before each iteration
- **Use cases**: User input validation, reading data until a condition is met

```csharp
int count = 0;
while (count < 5)
{
    Console.WriteLine("Count: " + count);
    count++;
}
```

### 3. Do-While Loop
- **Best for**: When you need to execute the loop at least once
- **Structure**: Code executes first, then condition is checked
- **Use cases**: Menu systems, input validation where you need at least one attempt

```csharp
int number = 0;
do
{
    Console.WriteLine("Number: " + number);
    number++;
}
while (number < 5);
```

## Key Differences

| Loop Type | When Condition is Checked | Minimum Executions | Best Use Case |
|-----------|---------------------------|-------------------|---------------|
| for | Before each iteration | 0 | Known iteration count |
| while | Before each iteration | 0 | Condition-dependent |
| do-while | After each iteration | 1 | At least one execution needed |

## Activities Included

### 1. Loop Discovery Demo
- Side-by-side comparison of all three loop types
- Exploration of loop behavior with different conditions
- Modified examples showing flexibility of each loop type

### 2. Beginner Practice Tasks
- **Count Up**: Print numbers 1-10 using loops
- **Even Numbers**: Display even numbers 2-20
- **Number Guessing**: Interactive guessing game with user input

### 3. Loop Challenges
- **Star Triangle**: Create patterns using nested loops
- **Prime Number Finder**: Input validation with mathematical logic
- **Menu System**: Real-world application of do-while loops

## Programming Concepts Demonstrated

### Loop Control
- Initialization of loop variables
- Condition evaluation and boolean logic
- Increment/decrement operations
- Loop termination strategies

### User Interaction
- Input validation using loops
- Menu-driven programs
- Error handling with retry mechanisms

### Nested Loops
- Pattern creation (star triangles)
- Multi-dimensional iteration
- Performance considerations

### Mathematical Applications
- Prime number detection algorithm
- Counting and accumulation patterns
- Range-based operations

## Best Practices Learned

1. **Choose the Right Loop**: Match the loop type to your specific need
2. **Avoid Infinite Loops**: Always ensure your condition can become false
3. **Initialize Variables**: Properly set up loop control variables
4. **Input Validation**: Use loops to handle invalid user input gracefully
5. **Readable Code**: Use meaningful variable names and clear conditions

## Common Patterns

### Input Validation Pattern
```csharp
int number;
do
{
    Console.Write("Enter a positive number: ");
} 
while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);
```

### Menu System Pattern
```csharp
string choice;
do
{
    DisplayMenu();
    choice = Console.ReadLine();
    ProcessChoice(choice);
}
while (choice != "exit");
```

### Counting Pattern
```csharp
for (int i = start; i <= end; i += step)
{
    // Process each number
}
```

## Tips for Success

1. **Start Simple**: Begin with basic counting loops before moving to complex logic
2. **Test Edge Cases**: What happens when the condition is false from the start?
3. **Use Debugger**: Step through loops to understand execution flow
4. **Practice Patterns**: The more you use common loop patterns, the more natural they become
5. **Plan Your Logic**: Think through the loop's purpose before writing code

## Running the Activities

Navigate to the SectionD directory and run:
```bash
dotnet run
```

The program provides an interactive menu to explore all loop concepts and complete the activities at your own pace.

## Next Steps

After mastering loops, you'll be ready to tackle:
- Arrays and collections (where loops become essential)
- Methods and functions (organizing repetitive code)
- File processing (reading data line by line)
- Algorithm implementation (sorting, searching)

Loops are fundamental to programming - they're used in almost every significant program you'll write!