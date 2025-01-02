# Overview
The Flyweight Pattern is a structural design pattern that reduces memory usage and improves performance by sharing a large number of fine-grained objects. The core idea of the meta-mode is to divide the state of an object into internal state and external state. The internal state can be shared, while the external state can be changed. By sharing internal state, the meta-mode can significantly reduce memory consumption.

# Structure
The meta pattern contains the following roles:

1. The Flyweight: Defines the interface of the flyweight object, through which the flyweight can be accepted and used for external state.
2. ConcreteFlyweight: Implements the concreteFlyweight interface and adds storage space for internal state.
3. The unshared specific flyweight (UnsharedConcreteFlyweight) : not all the flyweight objects can be Shared and non-shared metaclass is cannot be Shared.
4. FlyweightFactory: Create and manage flyweightFactory objects to ensure reasonable sharing of flyweightfactory objects.

# Sample code
Suppose we have an application that needs to draw a large number of tree objects, each of which is the same type and color, but in a different location.

**Flyweight Interface**
```csharp
public interface ITree
{
    void Display(int x, int y);
}
```

**Specific Flyweight**
```csharp
public class Tree : ITree
{
    private string _type;
    private string _color;

    public Tree(string type, string color)
    {
        _type = type;
        _color = color;
    }

    public void Display(int x, int y)
    {
        Console.WriteLine($"Tree of type {_type} and color {_color} is at ({x}, {y})");
    }
}
```

**Flyweight Factory**
```csharp
public class TreeFactory
{
    private Dictionary<string, ITree> _trees = new Dictionary<string, ITree>();

    public ITree GetTree(string type, string color)
    {
        string key = $"{type}_{color}";
        if (!_trees.ContainsKey(key))
        {
            _trees[key] = new Tree(type, color);
        }
        return _trees[key];
    }
}
```

**Client Code**
```csharp
class Program
{
    static void Main(string[] args)
    {
        TreeFactory treeFactory = new TreeFactory();

        ITree tree1 = treeFactory.GetTree("Oak", "Green");
        tree1.Display(10, 20);

        ITree tree2 = treeFactory.GetTree("Pine", "Green");
        tree2.Display(30, 40);

        ITree tree3 = treeFactory.GetTree("Oak", "Green");
        tree3.Display(50, 60);

        // tree1 and tree3 are the same object
        Console.WriteLine(object.ReferenceEquals(tree1, tree3)); // true
    }
}
```

# Application Scenarios
The meta mode applies to the following scenarios:

1. When a system has a large number of similar objects, the share mode can be used to reduce memory consumption.
2. The share pattern can be used when most of the state of an object can be externalized.
3. You can use the share mode when a large number of fine-grained objects are required in the system.

# Advantages and disadvantages
**Advantages**
* Reduced memory consumption: By sharing objects, sharing meta mode can significantly reduce memory consumption.
* Improved performance: Thanks to reduced memory consumption, share mode can improve system performance.
**Disadvantages**
* Increases system complexity: The share meta pattern introduces the concept of shared objects, increasing the complexity of the system.
* Need to distinguish between internal and external states: When using the share mode, you need to carefully distinguish between an object's internal and external states.
