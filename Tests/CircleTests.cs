using GeometryLib;

namespace Tests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void CalculateArea_CorrectRadius_ReturnsCorrectArea()
    {
        // arrange
        const double expectedCircleArea = 1963.4954084936207;
        var circle = new Circle(25);

        // act
        var circleArea = circle.Area;

        // assert
        Assert.AreEqual(expectedCircleArea, circleArea);
    }

    [TestMethod]
    public void CreateCircle_ZeroRadius_ArgumentOutOfRangeException()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(0));
    }

    [TestMethod]
    public void CreateCircle_NegativeRadius_ArgumentOutOfRangeException()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-25));
    }

    [TestMethod]
    public void CalculatePerimeter_NonNegativeRadius_ReturnsCorrectPerimeter()
    {
        // arrange
        const double eps = 1e-2;
        const double expectedCirclePerimeter = 45.55;
        var circle = new Circle(7.25);

        // act
        var circlePerimeter = circle.Perimeter;

        // assert
        Assert.AreEqual(expectedCirclePerimeter, circlePerimeter, eps);
    }
}