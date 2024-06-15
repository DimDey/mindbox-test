using FluentAssertions;
using ShapesLibrary.Abstractions;
using ShapesLibrary.Factories;
using ShapesLibrary.Shapes;

namespace ShapesLibrary.Tests.Factories;

public class ShapeFactoryTests
{
    private readonly IShapeFactory _shapeFactory = new ShapeFactory();
    
    [Fact]
    public void CreateCircle_ShouldReturnCircleInstance()
    {
        // Arrange
        const int radius = 10;

        // Act
        var shape = _shapeFactory.CreateCircle(radius);
        var shapeArea = shape.CalculateArea();
        var shapePerimeter = shape.CalculatePerimeter();

        // Assert
        shape.Should().BeOfType<Circle>();
        shapeArea.Should().Be(Math.PI * radius * radius);
        shapePerimeter.Should().Be(2 * Math.PI * radius);
    }

    [Fact]
    public void CreateTriangle_ShouldReturnTriangleInstance()
    {
        // Arrange
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;

        // Act
        var shape = _shapeFactory.CreateTriangle(sideA, sideB, sideC);
        var shapeArea = shape.CalculateArea();
        var shapePerimeter = shape.CalculatePerimeter();

        // Assert
        shape.Should().BeOfType<Triangle>();
        shapeArea.Should().Be(6);
        shapePerimeter.Should().Be(12);
    }
}