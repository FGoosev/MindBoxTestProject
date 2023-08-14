using CalculateSquareLib.Interfaces;

namespace CalculateSquareLib.Models;

public class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalcSquare()
    {
        return Math.Round(Math.PI * Math.Pow(_radius, 2), 1);
    }
}