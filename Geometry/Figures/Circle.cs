using Geometry.Base;

namespace Geometry.Figures;

public class Circle : Figure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Получено некорректное значение радиуса. Радиус должен быть > 0");
        }

        this.Radius = radius;
    }
    
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}