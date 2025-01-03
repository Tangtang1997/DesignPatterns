namespace _11_VisitorPattern;

public class Rectangle(double width, double height) : IShape
{
    public double Width { get; set; } = width;
    public double Height { get; set; } = height;

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}