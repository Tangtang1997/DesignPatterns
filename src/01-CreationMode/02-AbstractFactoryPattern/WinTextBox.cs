namespace _02_AbstractFactoryPattern;

public class WinTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows text box.");
    }
}