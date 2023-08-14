using CalculateSquareLib.Models;

namespace CalculateSquareLib.Tests;

public class CircleTests
{
    private Circle _circle;

    [SetUp]
    public void Setup()
    {
        _circle = new Circle(5);
    }

    [TestCase(2)]
    [TestCase(3)]
    [TestCase(4)]
    public void TestTriangleCreate(double x)
    {
        _circle = new Circle(x);
    
        Assert.Pass();
    }
    
    [Test]
    public void TestTriangleCalcSquare()
    {
        var res = _circle.CalcSquare();
        var expected = 78.5;
        Assert.That(res, Is.EqualTo(expected));

    }
}