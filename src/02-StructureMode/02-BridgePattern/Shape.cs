namespace _02_BridgePattern;

public abstract class Shape(IColor color)
{
    protected IColor Color = color;

    public abstract void Draw();
}