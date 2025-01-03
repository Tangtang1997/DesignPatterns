namespace _11_VisitorPattern;

public interface IShape
{
    void Accept(IVisitor visitor);
}