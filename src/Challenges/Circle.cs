using System;

public class Circle
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set
        {
            if (value > 0)
            {
                radius = value;
            }
            else
            {
                Console.WriteLine("Invalid radius. Radius must be positive. Setting to 1.");
                radius = 1;
            }
        }
    }

    public double GetArea()
    {
        // Area = π * r^2
        return Math.PI * Math.Pow(radius, 2);
    }

    public double GetCircumference()
    {
        // Circumference = 2 * π * r
        return 2 * Math.PI * radius;
    }
}