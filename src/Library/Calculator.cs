namespace Library;

// Force CI rebuild
public class Calculator
{
    public int Add(int a, int b) => a + b;

    public double Add(double a, double b) => a + b;

    public int Subtract(int a, int b) => a - b;

    public int Multiply(int a, int b) => a * b;

    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return (double)a / b;
    }

    public double CircleArea(double radius)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius cannot be negative.");
        return Math.PI * radius * radius;
    }
}
