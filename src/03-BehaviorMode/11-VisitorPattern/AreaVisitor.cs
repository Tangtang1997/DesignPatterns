namespace _11_VisitorPattern;

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