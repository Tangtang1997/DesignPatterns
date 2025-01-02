namespace _03_CompositePattern;

public class File(string name) : IFileSystemComponent
{
    public void Display(string indent)
    {
        Console.WriteLine($"{indent}- {name}");
    }
}