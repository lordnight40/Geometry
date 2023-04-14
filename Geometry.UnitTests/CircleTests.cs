using Geometry.Base;
using Geometry.Figures;

namespace Geometry.UnitTests;

public class CircleTests
{
    /// <summary>
    /// Тест на корректный расчет площади фигуры.
    /// </summary>
    [Test]
    public void CorrectAreaCalculatingTest()
    {
        var figure = new Circle(10);

        Assert.That(
            figure.CalculateArea().ToString(Common.FloatingValueFormat),
            Is.EqualTo(314.159265.ToString(Common.FloatingValueFormat)));
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
    /// Набор тестовых данных.
    /// </summary>
    public static IEnumerable<Figure> IncorrectFigures
    {
        get
        {
            yield return new Circle(0);
            yield return new Circle(-1);
        }
    }
}
