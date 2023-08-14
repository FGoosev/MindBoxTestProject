using CalculateSquareLib.Models;

namespace CalculateSquareLib.Tests.Tests;

public class Tests
{
    private Triangle _triangle;

    [SetUp]
    public void Setup()
    {
        _triangle = new Triangle(3, 3, 4);
    }

    [TestCase(2, 2, 3)]
    [TestCase(3, 3, 4)]
    [TestCase(4, 4, 1)]
    public void TestTriangleCreate(double x, double y, double z)
    {
        _triangle = new Triangle(x, y, z);

        Assert.Pass();
    }

    [Test]
    public void TestTriangleCalcSquare()
    {
        var expected = 4.5;

        var result = _triangle.CalcSquare();
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void IsRectTest()
    {
        var res = _triangle.IsRect();
        Assert.IsFalse(res);
    }
}