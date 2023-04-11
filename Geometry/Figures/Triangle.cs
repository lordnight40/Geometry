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
        this.FirstSide = firstSide;
        this.SecondSide = secondSide;
        this.ThirdSide = thirdSide;
    }

    /// <inheritdoc/>
    public override double CalculateArea()
    {
        ValidateFigure();
        
        var semiPerimeter = CalculateSemiPerimeter();

        return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
    }

    /// <summary>
    /// Метод вычисления полупериметра.
    /// </summary>
    /// <returns></returns>
    private double CalculateSemiPerimeter() => (FirstSide + SecondSide + ThirdSide) / 2;

    protected override void ValidateFigure()
    {
        if (FirstSide <= 0 || SecondSide <= 0 || ThirdSide <= 0)
        {
            throw new ArgumentException("Получено некорректное значение длины стороны треугольника. Длина должна быть > 0");
        }

        if (FirstSide > SecondSide + ThirdSide ||
            SecondSide > FirstSide + ThirdSide ||
            ThirdSide > FirstSide + SecondSide)
        {
            throw new ArgumentException("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать.");
        }
    }
}