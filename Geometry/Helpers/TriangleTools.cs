using Geometry.Base;
using Geometry.Figures;

namespace Geometry.Helpers;
public static class TriangleTools
{
    public static bool IsRectangular(Figure figure)
    {
        ArgumentNullException.ThrowIfNull(figure, nameof(figure));

        if (figure is not Triangle triangle)
        {
            throw new InvalidOperationException("Это не треугольник.");
        }

        if (Math.Pow(triangle.FirstSide, 2) == Math.Pow(triangle.SecondSide, 2) + Math.Pow(triangle.ThirdSide, 2) ||
            Math.Pow(triangle.SecondSide, 2) == Math.Pow(triangle.FirstSide, 2) + Math.Pow(triangle.ThirdSide, 2) ||
            Math.Pow(triangle.ThirdSide, 2) == Math.Pow(triangle.FirstSide, 2) + Math.Pow(triangle.SecondSide, 2))
        {
            return true;
        }

        return false;
    }
}