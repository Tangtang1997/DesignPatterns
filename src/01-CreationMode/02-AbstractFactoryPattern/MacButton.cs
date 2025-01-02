namespace _02_AbstractFactoryPattern;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Mac button.");
    }
}