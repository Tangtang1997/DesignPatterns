namespace _03_CompositePattern;

public class Directory(string name) : IFileSystemComponent
{
    private readonly List<IFileSystemComponent> _components = [];

    public void Add(IFileSystemComponent component)
    {
        _components.Add(component);
    }

    public void Remove(IFileSystemComponent component)
    {
        _components.Remove(component);
    }

    public void Display(string indent)
    {
        Console.WriteLine($"{indent}+ {name}");

        foreach (var component in _components)
        {
            component.Display(indent + "  ");
        }
    }
}