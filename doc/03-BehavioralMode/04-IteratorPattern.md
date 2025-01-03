# Overview

The Iterator Pattern is a behavioral design pattern that provides a way to access elements of an aggregate object sequentially without exposing the object's internal representation. Iterator patterns iterate over aggregate objects by introducing iterator objects, allowing clients to consistently access elements in aggregate objects without needing to understand their internal structure.

# Structure

The iterator pattern contains the following roles:

1. Iterator: Defines the interface for accessing and traversing elements.
2. ConcreteIterator: Implements an iterator interface that iterates over elements in the aggregate object.
3. Aggregate: Defines the interface for creating iterator objects.
4. ConcreteAggregate: Implements the aggregate interface and returns an instance of a concrete iterator.

# Sample Code

Suppose we have an application that needs to iterate over a custom collection object.

**Iterator Interface**

```csharp
public interface IIterator<T>
{
    bool HasNext();
    T Next();
}
```

**Aggregate Interface**

```csharp
public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}
```

**Specific Aggregate**

```csharp
public class CustomCollection<T> : IAggregate<T>
{
    private readonly List<T> _items = [];

    public void Add(T item)
    {
        _items.Add(item);
    }

    public IIterator<T> CreateIterator()
    {
        return new CustomIterator(this);
    }

    public int Count => _items.Count;

    public T this[int index] => _items[index];

    private class CustomIterator(CustomCollection<T> collection) : IIterator<T>
    {
        private int _currentIndex;

        public bool HasNext()
        {
            return _currentIndex < collection.Count;
        }

        public T Next()
        {
            return collection[_currentIndex++];
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
        CustomCollection<string> collection = new CustomCollection<string>();
        collection.Add("Item 1");
        collection.Add("Item 2");
        collection.Add("Item 3");

        IIterator<string> iterator = collection.CreateIterator();

        while (iterator.HasNext())
        {
            string item = iterator.Next();
            Console.WriteLine(item);
        }
    }
}
```

# Application Scenarios

The iterator mode is suitable for the following scenarios:

1. Access the content of an aggregate object: When you need to access the content of an aggregate object without exposing its internal representation.
2. Traversing different aggregate structures: When you need to traverse different aggregate structures, such as lists, trees, graphs, etc.
3. Unified traversal interface: When you need to provide a unified traversal interface for different aggregation structures.

# Advantages and disadvantages

**Advantages**

* Simplify aggregate classes: The iterator pattern simplifies the design of aggregate classes by separating the responsibility of traversing aggregate objects into iterator objects.
* Consistent traversal interface: The iterator pattern provides a consistent traversal interface for different aggregation structures, increasing the flexibility and extensibility of the system.

**Disadvantages**

* Increase the number of classes: The iterator pattern introduces iterator classes, which may increase the number of classes in the system and increase the complexity of the system.
