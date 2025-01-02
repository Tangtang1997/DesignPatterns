namespace _02_BridgePattern;

public class Circle(IColor color) : Shape(color)
{
    public override void Draw()
    {
        Console.Write("Drawing Circle with ");
        Color.ApplyColor();
    }
}