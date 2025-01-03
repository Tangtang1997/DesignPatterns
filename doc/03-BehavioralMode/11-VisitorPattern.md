# Overview

A Visitor Pattern is a behavioral design pattern that adds an access operation to each element in an object structure, making it possible to define new operations on those elements without changing the element class. The visitor pattern separates the logic of operations from the object structure, making it easy for new operations to be added to the object structure.

# Structure

The visitor pattern contains the following roles:

1. Visitor: Defines an access interface that declares an access operation for each concrete element class.
2. ConcreteVisitor (ConcreteVisitor) ** : Implements the visitor interface, providing a concrete implementation of access operations for each concrete element class.
3. Element: Defines a method that accepts an access operation and accepts a visitor object as a parameter.
4. ConcreteElement: Implements an element interface, defining methods for receiving access operations.
5. ObjectStructure: A collection of elements that can be traversed and accessed.

# Sample Code

Suppose we have an application that needs to perform operations on different types of shapes (such as calculating area and drawing shapes).

**Visitor Interface**

```csharp
public interface IVisitor
{
    void Visit(Circle circle);
    void Visit(Rectangle rectangle);
}
```

**Specific Visitors**

```csharp
public class AreaVisitor : IVisitor
{
    public void Visit(Circle circle)
    {
        double area = Math.PI * circle.Radius * circle.Radius;
        Console.WriteLine($"Circle area: {area}");
    }

    public void Visit(Rectangle rectangle)
    {
        double area = rectangle.Width * rectangle.Height;
        Console.WriteLine($"Rectangle area: {area}");
    }
}

public class DrawVisitor : IVisitor
{
    public void Visit(Circle circle)
    {
        Console.WriteLine("Drawing a circle");
    }

    public void Visit(Rectangle rectangle)
    {
        Console.WriteLine("Drawing a rectangle");
    }
}
```

**Element Interface**

```csharp
public interface IShape
{
    void Accept(IVisitor visitor);
}
```

**Specific Elements**

```csharp
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
```

**Client Code**

```csharp
class Program
{
    static void Main(string[] args)
    {
        List<IShape> shapes = new List<IShape>
        {
            new Circle(5),
            new Rectangle(4, 6)
        };

        IVisitor areaVisitor = new AreaVisitor();
        IVisitor drawVisitor = new DrawVisitor();

        foreach (var shape in shapes)
        {
            shape.Accept(areaVisitor);
            shape.Accept(drawVisitor);
        }
    }
}
```

# Application Scenarios

The visitor pattern applies to the following scenarios:

1. Object structure stability: When the object structure is stable, but a new operation needs to be defined on the object structure, the visitor mode can be used.
2. Different operations need to be performed on elements in the object structure: The visitor mode can be used when different operations need to be performed on elements in the object structure and these operations may change frequently.
3. Avoid contaminating element classes: When you do not want to add new operations to element classes, you can use the visitor mode to separate out the operation logic.

# Advantages and disadvantages

**Advantages**

* Easy to add new actions: The Visitor mode makes it easy to add new actions by simply adding a new visitor class.
* Conforms to the single responsibility principle: The visitor pattern separates the operational logic into the visitor class, making the element class focus only on its own data structure.
* Conforms to the open-close principle: The visitor pattern makes it possible to add new operations to the object structure without modifying the element class.

**Disadvantages**

* Increase system complexity: The visitor pattern introduces a dual allocation mechanism of visitors and elements, which may increase system complexity.
* Violation of the dependency inversion principle: The visitor pattern depends on concrete classes, not abstract classes, and may violate the dependency inversion principle.