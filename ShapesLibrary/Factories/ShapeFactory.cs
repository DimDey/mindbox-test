using ShapesLibrary.Abstractions;
using ShapesLibrary.Abstractions.Shapes;
using ShapesLibrary.Shapes;

namespace ShapesLibrary.Factories;

/// <inheritdoc cref="IShapeFactory"/>
public class ShapeFactory : IShapeFactory
{
    /// <inheritdoc cref="IShapeFactory.CreateCircle"/>
    public IShape CreateCircle(double radius)
    {
        return new Circle(radius);
    }

    /// <inheritdoc cref="IShapeFactory.CreateTriangle"/>
    public IShape CreateTriangle(double sideA, double sideB, double sideC)
    {
        return new Triangle(sideA, sideB, sideC);
    }
}