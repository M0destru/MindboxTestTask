using GeometryLib;

namespace Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    [DataRow(5, 3, 3, 4.1458)]
    [DataRow(1, 1, 2, 0)]
    [DataRow(4, 6, 7, 11.9765)]
    [DataRow(1.1, 4.3, 3.3, 0.8615)]
    public void CalculateArea_CorrectTriangleSides_ReturnsCorrectArea(double value1, double value2, double value3,
        double expected)
    {
        // arrange
        const double eps = 1e-4;
        var triangle = new Triangle(value1, value2, value3);

        // act
        var triangleArea = triangle.Area;

        // assert
        Assert.AreEqual(expected, triangleArea, eps);
    }

    [TestMethod]
    [DataRow(1, 1, 3)]
    [DataRow(5.2, 1, 2)]
    [DataRow(2, 5, 2)]
    public void CreateTriangle_TriangleNotExists_ArgumentException(double value1, double value2, double value3)
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(value1, value2, value3));
    }

    [TestMethod]
    [DataRow(0, 1, 3)]
    [DataRow(1.4, 0, 3)]
    [DataRow(2.6, 1.8, 0)]
    public void CreateTriangle_ZeroTriangleSide_ArgumentException(double value1, double value2, double value3)
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(value1, value2, value3));
    }

    [TestMethod]
    [DataRow(3, 4, 5)]
    [DataRow(3.6, 4.8, 6)]
    [DataRow(4.2, 7, 5.6)]
    [DataRow(41, 40, 9)]
    public void CheckTriangleIsRight_ReturnTrue(double value1, double value2, double value3)
    {
        // arrange
        var triangle = new Triangle(value1, value2, value3);

        // act
        var isRightTriangle = triangle.IsRight;

        // assert
        Assert.IsTrue(isRightTriangle);
    }

    [TestMethod]
    [DataRow(3, 5, 7)]
    [DataRow(11, 18.1, 17)]
    [DataRow(3.7, 7, 6)]
    public void CheckTriangleIsRight_ReturnFalse(double value1, double value2, double value3)
    {
        // arrange
        var triangle = new Triangle(value1, value2, value3);

        // act
        var isRightTriangle = triangle.IsRight;

        // assert
        Assert.IsFalse(isRightTriangle);
    }
}