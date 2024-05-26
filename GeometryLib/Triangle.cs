namespace GeometryLib;

public class Triangle : Figure
{
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("The sides of the triangle must be greater than 0");

        if (a + b < c || b + c < a || a + c < b)
            throw new ArgumentException(
                "The length of any side of a triangle must be less than the sum of the lengths of its other two sides.");

        A = a;
        B = b;
        C = c;
    }

    /// <summary>
    ///     Сторона треугольника А
    /// </summary>
    public double A { get; }

    /// <summary>
    ///     Сторона треугольника B
    /// </summary>
    public double B { get; }

    /// <summary>
    ///     Сторона треугольника C
    /// </summary>
    public double C { get; }

    /// <summary>
    ///     Является ли треугольник прямоугольным
    /// </summary>
    public bool IsRight => IsRightTriangle();

    protected override double CalculateArea()
    {
        var halfPerimeter = Perimeter / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
    }

    protected override double CalculatePerimeter()
    {
        return A + B + C;
    }

    /// <summary>
    ///     Проверяет является ли треугольник прямоугольным
    /// </summary>
    /// <returns>true если треугольник является прямоугольным, иначе, false.</returns>
    private bool IsRightTriangle()
    {
        var hypotenuse = Math.Max(A, Math.Max(B, C));

        return Math.Abs(2 * (hypotenuse * hypotenuse) - (A * A + B * B + C * C)) < Eps;
    }
}