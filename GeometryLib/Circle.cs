namespace GeometryLib;

public class Circle : Figure
{
    public Circle(double r)
    {
        if (r <= 0) throw new ArgumentOutOfRangeException(nameof(r), "The radius of the circle must be greater than 0");

        R = r;
    }

    /// <summary>
    ///     Радиус окружности
    /// </summary>
    public double R { get; }

    protected override double CalculateArea()
    {
        return Math.PI * Math.Pow(R, 2);
    }

    protected override double CalculatePerimeter()
    {
        return 2 * Math.PI * R;
    }
}