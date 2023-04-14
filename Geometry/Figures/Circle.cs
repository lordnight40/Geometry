using Geometry.Base;

namespace Geometry.Figures;

/// <summary>
/// Круг.
/// </summary>
public class Circle : Figure
{
    /// <summary>
    /// Радиус.
    /// </summary>
    public double Radius { get; }

    public Circle(double radius)
    {
        this.Radius = radius;
    }
    
    /// <inheritdoc/>
    public override double CalculateArea()
    {
        ValidateFigure();
        
        return Math.PI * Math.Pow(Radius, 2);
    }

    /// <inheritdoc/>
    protected override void ValidateFigure()
    {
        if (Radius <= 0)
        {
            throw new InvalidOperationException("Получено некорректное значение радиуса. Радиус должен быть > 0");
        }
    }
}