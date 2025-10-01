using System;

public class Rectangle
{
    private double length;
    private double width;

    public double Length
    {
        get { return length; }
        set
        {
            if (value > 0)
            {
                length = value;
            }
            else
            {
                Console.WriteLine("Invalid length. Length must be positive. Setting to 1.");
                length = 1;
            }
        }
    }

    public double Width
    {
        get { return width; }
        set
        {
            if (value > 0)
            {
                width = value;
            }
            else
            {
                Console.WriteLine("Invalid width. Width must be positive. Setting to 1.");
                width = 1;
            }
        }
    }

    public double GetArea()
    {
        return length * width;
    }

    public double GetPerimeter()
    {
        return 2 * (length + width);
    }
}