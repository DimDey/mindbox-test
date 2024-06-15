using ShapesLibrary.Abstractions.Shapes;

namespace ShapesLibrary.Abstractions;

/// <summary>
/// Фабрика для создания геометрических фигур
/// </summary>
public interface IShapeFactory
{
    /// <summary>
    /// Создание фигуры круга
    /// </summary>
    /// <param name="radius">Радиус круга</param>
    /// <returns>Реализацию фигуры круга</returns>
    public IShape CreateCircle(double radius);

    /// <summary>
    /// Создание фигуры треугольника
    /// </summary>
    /// <param name="sideA">Сторона А</param>
    /// <param name="sideB">Сторона Б</param>
    /// <param name="sideC">Сторона C</param>
    /// <returns>Реализацию фигуры треугольника</returns>
    public IShape CreateTriangle(double sideA, double sideB, double sideC);
}