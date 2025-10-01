public class Student
{
    public int ID { get; set; }
    public string Major { get; set; } = string.Empty;
    public double GPA { get; set; }

    public bool IsHonorRoll()
    {
        return GPA >= 3.5;
    }
}