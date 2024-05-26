namespace GeometryLib;

/// <summary>
///     Абстрактный класс для описания геометрических фигур
/// </summary>
public abstract class Figure
{
    protected const double Eps = 1e-10;

    /// <summary>
    ///     Площадь фигуры
    /// </summary>
    public double Area => CalculateArea();

    /// <summary>
    ///     Периметр фигуры
    /// </summary>
    public double Perimeter => CalculatePerimeter();

    /// <summary>
    ///     Вычисляет площадь фигуры
    /// </summary>
    /// <returns>double Значение площади</returns>
    protected abstract double CalculateArea();

    /// <summary>
    ///     Вычисляет периметр фигуры
    /// </summary>
    /// <returns>double Значение периметра</returns>
    protected abstract double CalculatePerimeter();
}