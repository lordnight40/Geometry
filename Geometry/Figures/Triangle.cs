using Geometry.Base;

namespace Geometry.Figures;

public class Triangle : Figure
{
    private double firstSide;

    private double secondSide;

    private double thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new ArgumentException("Получено некорректное значение длины стороны треугольника. Длина должна быть > 0");
        }
        
        this.firstSide = firstSide;
        this.secondSide = secondSide;
        this.thirdSide = thirdSide;
    }

    public override double CalculateArea()
    {
        var semiPerimeter = CalculateSemiPerimeter();

        return Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));
    }

    private double CalculateSemiPerimeter() => (firstSide + secondSide + thirdSide) / 2;
}