namespace ShapesLibrary.Abstractions.Shapes;

/// <summary>
/// Геометрический треугольник. Наследует интерфейс геометрической фигуры
/// </summary>
public interface ITriangle : IShape
{
    /// <summary> Сторона A </summary>
    public double SideA { get; }
    
    /// <summary> Сторона B </summary>
    public double SideB { get; }
    
    /// <summary> Сторона C </summary>
    public double SideC { get; }
    
    /// <summary>
    /// Метод проверки является ли треугольник прямоугольным
    /// </summary>
    bool IsRightAngled();
}