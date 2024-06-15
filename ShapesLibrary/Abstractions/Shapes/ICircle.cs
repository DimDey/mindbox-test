namespace ShapesLibrary.Abstractions.Shapes;

/// <summary>
/// Геометрическая фигура круга
/// </summary>
public interface ICircle : IShape
{
    /// <summary>
    /// Радиус круга
    /// </summary>
    public double Radius { get;  }
}