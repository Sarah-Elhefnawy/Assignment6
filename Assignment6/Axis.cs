namespace Assignment6_Part1;

public struct Axis
{
    public double x, y;

    public Axis(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public void PrintAxis()
    {
        Console.WriteLine($"x = {x}, y = {y}");
    }
}
