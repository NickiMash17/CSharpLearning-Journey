using System;

class Rectangle
{
    private double length;  // Encapsulation with private fields
    private double width;

    // Properties with validation
    public double Length
    {
        get { return length; }
        set
        {
            if (value > 0)
                length = value;
            else
                throw new ArgumentException("Length must be positive");
        }
    }

    public double Width
    {
        get { return width; }
        set
        {
            if (value > 0)
                width = value;
            else
                throw new ArgumentException("Width must be positive");
        }
    }

    // Methods
    public double GetArea()
    {
        return length * width;
    }

    public double GetPerimeter()
    {
        return 2 * (length + width);
    }
}

class Program2
{
    static void Main()
    {
        Rectangle rect = new Rectangle();
        rect.Length = 5;
        rect.Width = 3;

        Console.WriteLine($"Rectangle Length: {rect.Length}, Width: {rect.Width}");
        Console.WriteLine($"Area: {rect.GetArea()}");
        Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");
    }
}
