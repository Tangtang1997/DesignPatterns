# Overview
A Composite Pattern is a structural design pattern that combines objects into a tree structure to represent a "parts-whole" hierarchy. The composite pattern allows customers to work with individual and composite objects in a unified manner. By using composite patterns, client code can consistently handle simple and complex elements, increasing the flexibility and scalability of the system.

# Structure
The composite mode contains the following roles:

1. Component: Defines interfaces for composite objects and leaf objects.
2. Leaf: Implements component interfaces and represents leaf objects.
3. Composite: Implements component interfaces, represents composite objects with sub-components, and defines management methods for sub-components.

# Sample code
Suppose we have an application that needs to represent files and folders in a file system.

**Component Interface**
```csharp
public interface IFileSystemComponent
{
    void Display(string indent);
}
```

**Leaf**
```csharp
public class File : IFileSystemComponent
{
    private string _name;

    public File(string name)
    {
        _name = name;
    }

    public void Display(string indent)
    {
        Console.WriteLine($"{indent}- {_name}");
    }
}
```

**Composite**
```csharp
public class Directory : IFileSystemComponent
{
    private string _name;
    private List<IFileSystemComponent> _components = new List<IFileSystemComponent>();

    public Directory(string name)
    {
        _name = name;
    }

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
        Console.WriteLine($"{indent}+ {_name}");
        foreach (var component in _components)
        {
            component.Display(indent + "  ");
        }
    }
}
```

**Client Code**
```csharp
class Program
{
    static void Main(string[] args)
    {
        IFileSystemComponent file1 = new File("File1.txt");
        IFileSystemComponent file2 = new File("File2.txt");
        IFileSystemComponent file3 = new File("File3.txt");

        Directory folder1 = new Directory("Folder1");
        folder1.Add(file1);

        Directory folder2 = new Directory("Folder2");
        folder2.Add(file2);
        folder2.Add(file3);

        Directory root = new Directory("Root");
        root.Add(folder1);
        root.Add(folder2);

        root.Display("");
    }
}
```

# Application Scenarios
The combination mode is applicable to the following scenarios:

1. When you wish to represent a partial - overall hierarchy of objects.
2. When you want the customer to ignore the difference between the combined object and the single object, the customer will use all the objects in the combined structure uniformly.

# Advantages and disadvantages
**Advantages**
Simplify client code: The composite pattern simplifies client code by allowing clients to work consistently with individual and composite objects.
* Easier to scale: The composite structure can be easily extended by adding new leaf nodes and composite nodes.

**Disadvantages**
May lead to too complex design: If the composition structure is too complex, it may lead to too complex system design.
