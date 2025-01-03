namespace _11_VisitorPattern;

public interface IVisitor
{
    void Visit(Circle circle);
    void Visit(Rectangle rectangle);
}