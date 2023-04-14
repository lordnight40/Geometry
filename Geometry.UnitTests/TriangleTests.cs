using Geometry.Base;
using Geometry.Figures;
using Geometry.Helpers;

namespace Geometry.UnitTests;

public class TriangleTests
{
    /// <summary>
    /// Тест на корректный расчет площади фигуры.
    /// </summary>
    [Test]
    public void CorrectAreaCalculatingTest()
    {
        var triangle = new Triangle(10, 15, 10);

        Assert.That(
            triangle.CalculateArea().ToString(Common.FloatingValueFormat),
            Is.EqualTo(49.6078.ToString(Common.FloatingValueFormat)));
    }

    /// <summary>
    /// Тест на то, что фигура может существовать.
    /// </summary>
    /// <param name="testFigures">Фигура.</param>
    [Test]
    [TestCaseSource(nameof(IncorrectFigures))]
    public void FigureCanExistsTest(Figure testFigures)
    {
        Assert.Catch<InvalidOperationException>(() => testFigures.CalculateArea());
    }

    /// <summary>
    /// Тест на то, что треугольник прямоугольный.
    /// </summary>
    /// <param name="testCaseData">Тестовые значения.</param>
    [Test]
    [TestCaseSource(nameof(Triangles))]
    public void RectangularTriangleTest(ValueTuple<Figure, bool> testCaseData)
    {
        Assert.That(TriangleTools.IsRectangular(testCaseData.Item1), Is.EqualTo(testCaseData.Item2));
    }

    /// <summary>
    /// Набор заведомо некорректных треугольников.
    /// </summary>
    public static IEnumerable<Figure> IncorrectFigures
    {
        get
        {
            yield return new Triangle(10, 30, 10);
            yield return new Triangle(10, 30, 0);
            yield return new Triangle(-1, 30, 10);
        }
    }

    /// <summary>
    /// Набор треугольников для тестирования на признак прямого угла.
    /// </summary>
    public static IEnumerable<ValueTuple<Figure, bool>> Triangles
    {
        get
        {
            yield return new ValueTuple<Figure, bool>(new Triangle(5, 3, 4), true);
            yield return new ValueTuple<Figure, bool>(new Triangle(5, 2, 3), false);
        }
    }
}