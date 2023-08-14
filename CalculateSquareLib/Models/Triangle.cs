using CalculateSquareLib.Interfaces;

namespace CalculateSquareLib.Models;

public class Triangle : Shape
{
    private readonly double _x;
    private readonly double _y;
    private readonly double _z;

    public Triangle(double x, double y, double z)
    {
        if(x < 0 || y < 0 || z < 0) throw new Exception("Not valid triangle");
        if (x > y + z || y > x + z || z > x + y) throw new Exception("Not valid triangle");
        _x = x;
        _y = y;
        _z = z;
    }

    public double CalcSquare()
    {
        double p = (_x + _y + _z) / 2;
        double res = Math.Round(Math.Sqrt(p * (p - _x) * (p - _y) * (p - _z)), 1);
        return res;
    }

    public bool IsRect()
    {
        if (_x == Math.Sqrt(Math.Pow(_y, 2) + Math.Pow(_z, 2))
            || _y == Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_z, 2))
            || _z == Math.Sqrt(Math.Pow(_y, 2) + Math.Pow(_x, 2))
           ) return true;
        return false;

    }
}