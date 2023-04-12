using Geometry.Base;
using Geometry.Figures;
using Geometry.Helpers;
using NUnit.Framework.Internal;
using System.Reflection;

namespace Geometry.UnitTests;

public class TriangleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectAreaCalculatingTest()
    {
        var triangle = new Triangle(10, 15, 10);

        Assert.That(
            triangle.CalculateArea().ToString(Common.FloatingValueFormat),
            Is.EqualTo(49.6078.ToString(Common.FloatingValueFormat)));
    }

    [Test]
    [TestCaseSource(nameof(IncorrectFigures))]
    public void FigureCanExistsTest(Figure testTriangle)
    {
        Assert.Catch<InvalidOperationException>(() => testTriangle.CalculateArea());
    }

    [Test]
    [TestCaseSource(nameof(Triangles))]
    public void RectangularTriangleTest(ValueTuple<Figure, bool> testCaseData)
    {
        Assert.That(TriangleTools.IsRectangular(testCaseData.Item1), Is.EqualTo(testCaseData.Item2));
    }

    public static IEnumerable<Figure> IncorrectFigures
    {
        get
        {
            yield return new Triangle(10, 30, 10);
            yield return new Triangle(10, 30, 0);
            yield return new Triangle(-1, 30, 10);
        }
    }

    public static IEnumerable<ValueTuple<Figure, bool>> Triangles
    {
        get
        {
            yield return new ValueTuple<Figure, bool>(new Triangle(5, 3, 4), true);
            yield return new ValueTuple<Figure, bool>(new Triangle(5, 2, 3), false);
        }
    }
}