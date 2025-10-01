using System;

public class Student
{
    private string major = string.Empty;

    // Properties
    public int ID { get; set; }
    public string Major 
    { 
        get { return major; }
        // Ensure Major is never null
        set { major = value ?? string.Empty; }
    }
    public double GPA { get; set; }

    // Method to check honor roll
    public bool IsHonorRoll()
    {
        return GPA >= 3.5;
    }
}