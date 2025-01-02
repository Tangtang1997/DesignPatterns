namespace _02_BridgePattern;

public class Rectangle(IColor color) : Shape(color)
{
    public override void Draw()
    {
        Console.Write("Drawing Rectangle with ");
        Color.ApplyColor();
    }
}