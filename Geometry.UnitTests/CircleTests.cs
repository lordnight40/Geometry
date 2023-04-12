using Geometry.Base;
using Geometry.Figures;

namespace Geometry.UnitTests;

public class CircleTests
{
    [Test]
    public void CorrectAreaCalculatingTest()
    {
        var figure = new Circle(10);

        Assert.That(
            figure.CalculateArea().ToString(Common.FloatingValueFormat),
            Is.EqualTo(314.159265.ToString(Common.FloatingValueFormat)));
    }

    [Test]
    [TestCaseSource(nameof(IncorrectFigures))]
    public void FigureCanExistsTest(Figure testFigures)
    {
        Assert.Catch<InvalidOperationException>(() => testFigures.CalculateArea());
    }

    public static IEnumerable<Figure> IncorrectFigures
    {
        get
        {
            yield return new Circle(0);
            yield return new Circle(-1);
        }
    }
}
