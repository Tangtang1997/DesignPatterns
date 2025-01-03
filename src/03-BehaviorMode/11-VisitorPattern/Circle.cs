namespace _11_VisitorPattern;

public class Circle(double radius) : IShape
{
    public double Radius { get; set; } = radius;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}