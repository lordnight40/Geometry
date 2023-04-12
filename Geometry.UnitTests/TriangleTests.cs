using Geometry.Figures;

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
        
        Assert.That(triangle.CalculateArea().ToString("F4"), Is.EqualTo(49.6078.ToString("F4")));
    }

    [Test]
    public void IncorrectInputTest()
    {
        var triangle = new Triangle(10, 30, 10);

        Assert.Catch<InvalidOperationException>(() => triangle.CalculateArea());
    }
}