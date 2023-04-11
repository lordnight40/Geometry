using Geometry.Base;

namespace Geometry.Figures;

public class Triangle : Figure
{
    public double FirstSide { get; }

    public double SecondSide { get; }
    
    public double ThirdSide { get; }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new ArgumentException("Получено некорректное значение длины стороны треугольника. Длина должна быть > 0");
        }
        
        this.FirstSide = firstSide;
        this.SecondSide = secondSide;
        this.ThirdSide = thirdSide;
    }

    public override double CalculateArea()
    {
        var semiPerimeter = CalculateSemiPerimeter();

        return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
    }

    private double CalculateSemiPerimeter() => (FirstSide + SecondSide + ThirdSide) / 2;
}