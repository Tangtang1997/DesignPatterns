namespace _02_AbstractFactoryPattern;

public class MacTextBox : ITextBox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Mac text box.");
    }
}