namespace _11_VisitorPattern;

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