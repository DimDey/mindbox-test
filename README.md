# Геометрическая библиотека

Эта библиотека предоставляет функциональность для вычисления площади и периметра различных геометрических фигур. Включает поддержку для круга, треугольника и прямоугольника. Также есть возможность легко добавлять новые фигуры.

## Установка

1. Склонируйте репозиторий:

    ```bash
    git clone https://github.com/your-repo/geometric-library.git
    ```

2. Перейдите в папку проекта:

    ```bash
    cd geometric-library
    ```

3. Постройте проект:

    ```bash
    dotnet build
    ```

## Использование

Пример использования библиотеки:

```csharp
using System;
using GeometricLibrary;

class Program
{
    static void Main()
    {
        IShape circle = ShapeFactory.CreateCircle(10);
        Console.WriteLine($"Circle area: {circle.CalculateArea()}");
        Console.WriteLine($"Circle perimeter: {circle.CalculatePerimeter()}");

        IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
        Console.WriteLine($"Triangle area: {triangle.CalculateArea()}");
        Console.WriteLine($"Triangle perimeter: {triangle.CalculatePerimeter()}");

        IShape rectangle = ShapeFactory.CreateRectangle(5, 10);
        Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
        Console.WriteLine($"Rectangle perimeter: {rectangle.CalculatePerimeter()}");
    }
}
```

## Поддерживаемые фигуры

### Круг

* Создание: `ShapeFactory.CreateCircle(double radius)`

#### Методы:
* `CalculateArea()`: Возвращает площадь круга.
* `CalculatePerimeter()`: Возвращает периметр (окружность) круга.

### Треугольник

* Создание: `ShapeFactory.CreateTriangle(double sideA, double sideB, double sideC)`

#### Методы:
* `CalculateArea()`: Возвращает площадь треугольника.
* `CalculatePerimeter()`: Возвращает периметр треугольника.
* `IsRightAngled()`: Возвращает true, если треугольник прямоугольный.

## Добавление новых фигур

Для добавления новой фигуры необходимо:
1. Создать новый класс, реализующий интерфейс IShape.
2. Реализовать методы CalculateArea и CalculatePerimeter.
3. Добавить метод создания новой фигуры в ShapeFactory.

### Пример для трапеции:
```csharp
public class Trapezoid : IShape
{
    public double BaseA { get; }
    public double BaseB { get; }
    public double Height { get; }

    public Trapezoid(double baseA, double baseB, double height)
    {
        if (baseA <= 0 || baseB <= 0 || height <= 0)
        {
            throw new ArgumentException("All dimensions must be greater than zero.");
        }
        BaseA = baseA;
        BaseB = baseB;
        Height = height;
    }

    public double CalculateArea()
    {
        return (BaseA + BaseB) / 2 * Height;
    }

    public double CalculatePerimeter()
    {
        // Примерная реализация, зависит от дополнительной информации
        throw new NotImplementedException();
    }
}
```

* Добавление в `ShapeFactory`:
```csharp
public static IShape CreateTrapezoid(double baseA, double baseB, double height)
{
    return new Trapezoid(baseA, baseB, height);
}
```


## Тестирование

Все тесты находятся в проекте GeometricLibrary.Tests и включают проверку корректности вычислений площадей и периметров, а также проверку корректности создания фигур.

Для запуска тестов выполните следующую команду:

```csharp
dotnet test
```

