using FluentAssertions;
using ShapesLibrary.Shapes;

namespace ShapesLibrary.Tests.Shapes;

public class CircleTests
{
    private const double EqualsPrecision = 0.01;
    
    [Fact]
    public void CalculateArea_ShouldReturnCorrectValue()
    {
        // Arrange
        var circle = new Circle(10);
        
        // Act
        var area = circle.CalculateArea();
        
        // Assert
        area.Should().BeApproximately(314.16, EqualsPrecision);
    }
    
    [Fact]
    public void CalculatePerimeter_ShouldReturnCorrectValue()
    {
        // Arrange
        var circle = new Circle(10);
        
        // Act
        var perimeter = circle.CalculatePerimeter();
        
        // Assert
        perimeter.Should().BeApproximately(62.83, EqualsPrecision);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Constructor_ShouldThrowArgumentException_WhenRadiusIsZeroOrNegative(int radius)
    {
        // Arrange
        var func = () => new Circle(radius);
        
        // Assert
        func.Should().Throw<ArgumentException>().WithMessage("Radius must be positive.");
    }
}