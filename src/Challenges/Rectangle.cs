public class Rectangle
{
    private double _length;
    public double Length
    {
        get { return _length; }
        set
        {
            if (value > 0)
            {
                _length = value;
            }
        }
    }

    private double _width;
    public double Width
    {
        get { return _width; }
        set
        {
            if (value > 0)
            {
                _width = value;
            }
        }
    }

    public double GetArea()
    {
        return Length * Width;
    }

    public double GetPerimeter()
    {
        return 2 * (Length + Width);
    }
}