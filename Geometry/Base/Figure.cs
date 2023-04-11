namespace Geometry.Base;

/// <summary>
/// Базовый абстрактный класс фигуры.
/// <remarks>Делаем так, потому что между дочерними классами и этим будет отношение "является".</remarks>
/// </summary>
public abstract class Figure
{
    /// <summary>
    /// Метод вычисления площади.
    /// </summary>
    /// <remarks>Можно было бы добавить этот метод через интерфейс (казалось бы отношение "поддерживает"),
    /// но площадь является атрибутом любой фигуры.
    /// </remarks>
    /// <returns>Площадь фигуры.</returns>
    public abstract double CalculateArea();
}