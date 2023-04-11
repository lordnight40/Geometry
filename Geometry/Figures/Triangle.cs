using Geometry.Base;

namespace Geometry.Figures;

/// <summary>
/// Треугольник.
/// </summary>
public class Triangle : Figure
{
    /// <summary>
    /// Первая сторона.
    /// </summary>
    public double FirstSide { get; }

    /// <summary>
    /// Вторая сторона.
    /// </summary>
    public double SecondSide { get; }
    
    /// <summary>
    /// Третья сторона.
    /// </summary>
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

    /// <inheritdoc/>
    public override double CalculateArea()
    {
        var semiPerimeter = CalculateSemiPerimeter();

        return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
    }

    /// <summary>
    /// Метод вычисления полупериметра.
    /// </summary>
    /// <returns></returns>
    private double CalculateSemiPerimeter() => (FirstSide + SecondSide + ThirdSide) / 2;
}