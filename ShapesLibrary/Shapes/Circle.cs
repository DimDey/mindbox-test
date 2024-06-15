using ShapesLibrary.Abstractions.Shapes;

namespace ShapesLibrary.Shapes;

/// <inheritdoc cref="ICircle"/>
public class Circle : ICircle
{
    /// <inheritdoc cref="ICircle.Radius"/>
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0) throw new ArgumentException("Radius must be positive.");
        Radius = radius;
    }
    
    /// <inheritdoc cref="IShape.CalculateArea"/>
    public double CalculateArea() => Math.PI * Radius * Radius;
    
    /// <inheritdoc cref="IShape.CalculatePerimeter"/>
    public double CalculatePerimeter() => 2 * Math.PI * Radius;
}