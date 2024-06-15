using FluentAssertions;
using ShapesLibrary.Shapes;

namespace ShapesLibrary.Tests.Shapes;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(3, 4, 6, 5.33)]
    public void CalculateArea_ShouldReturnCorrectValue(double sideA, double sideB, double sideC, double expectedArea)
    {
        // Arrange
        var triangle = new Triangle(sideA, sideB, sideC);
        
        // Act
        var factArea = triangle.CalculateArea();
            
        // Arrange
        factArea.Should().BeApproximately(expectedArea, 0.01);
    }
    
    [Fact]
    public void CalculatePerimeter_ShouldReturnCorrectValue()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);
        
        // Act
        var perimeter = triangle.CalculatePerimeter();
            
        // Assert
        perimeter.Should().Be(12);
    }

    [Fact]
    public void Constructor_ShouldThrowArgumentException_WhenTriangleHaveUnexpectedSides()
    {
        // Arrange
        var informAct = () => new Triangle(1, 1, 3);
        
        // Assert
        informAct.Should().Throw<ArgumentException>().WithMessage("The given sides do not form a triangle.");
    }
    
    [Fact]
    public void Constructor_ShouldThrowArgumentException_WhenTriangleHaveZeroSides()
    {
        // Arrange
        var zeroTriangleAct = () => new Triangle(1, -1, 3);
        
        // Assert
        zeroTriangleAct.Should().Throw<ArgumentException>().WithMessage("Sides must be positive.");
    }

    [Fact]
    public void IsRightAngled_ShouldReturnTrue_WhenTriangleIsRightAngled()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);
        
        // Act
        var isRightAngled = triangle.IsRightAngled();
            
        // Assert
        isRightAngled.Should().BeTrue();
    }

    [Fact]
    public void IsRightAngled_ShouldReturnFalse_WhenTriangleIsNotRightAngled()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 6);
        
        // Act
        var isRightAngled = triangle.IsRightAngled();
            
        // Assert
        isRightAngled.Should().BeFalse();
    }
}