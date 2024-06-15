namespace ShapesLibrary.Abstractions.Shapes;

/// <summary>
/// Геометрическая фигура
/// </summary>
public interface IShape
{
    /// <summary>
    /// Метод вычисления площади фигуры
    /// </summary>
    double CalculateArea();

    /// <summary>
    /// Метод вычисления периметра фигуры
    /// </summary>
    double CalculatePerimeter();
}