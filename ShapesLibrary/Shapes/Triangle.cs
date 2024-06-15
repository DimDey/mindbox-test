using ShapesLibrary.Abstractions.Shapes;

namespace ShapesLibrary.Shapes;

/// <inheritdoc cref="ITriangle"/>
public class Triangle : ITriangle
{
    /// <summary>
    /// Погрешность при сравнении
    /// </summary>
    private const double EqualsTolerance = 0.01;
    
    /// <inheritdoc cref="ITriangle.SideA"/>
    public double SideA { get; }
    
    /// <inheritdoc cref="ITriangle.SideB"/>
    public double SideB { get; }
    
    /// <inheritdoc cref="ITriangle.SideC"/>
    public double SideC { get; }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0) 
            throw new ArgumentException("Sides must be positive.");
        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("The given sides do not form a triangle.");
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    /// <inheritdoc cref="IShape.CalculatePerimeter"/>
    public double CalculatePerimeter() => SideA + SideB + SideC;

    /// <inheritdoc cref="IShape.CalculateArea"/>
    public double CalculateArea()
    {
        var semiPerimeter = CalculatePerimeter() / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }
    
    /// <inheritdoc cref="ITriangle.IsRightAngled"/>
    public bool IsRightAngled()
    {
        return Math.Abs(SideA * SideA + SideB * SideB - SideC * SideC) < EqualsTolerance
               || 
               Math.Abs(SideA * SideA + SideC * SideC - SideB * SideB) < EqualsTolerance
               || 
               Math.Abs(SideC * SideC + SideB * SideB - SideA * SideA) < EqualsTolerance;
    }
}