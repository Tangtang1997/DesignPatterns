namespace _02_AbstractFactoryPattern;

public class WinButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows button.");
    }
}