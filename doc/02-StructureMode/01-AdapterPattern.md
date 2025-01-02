# Overview
The Adapter Pattern is a structural design pattern that converts the interface of a class into another interface desired by the customer, allowing classes that would otherwise not work together due to interface incompatibility to work together. The adapter pattern solves the problem of interface incompatibility by introducing an adapter class, thereby improving the reusability and flexibility of the code.

# Structure
The adapter pattern contains the following roles:

1. Target interface: Defines the interface required by the customer.
2. An Adaptee: defines an existing interface that needs to be adapted.
3. Adapter: Implements the target interface and implements the target interface by calling the adapter's methods internally.

# Sample code
Suppose we have an application that needs to adapt an existing text formatting class to a new formatting interface.

**Target Interface**
```csharp
public interface ITextFormatter
{
    string FormatText(string text);
}
```

**Adaptee**
```csharp
public class LegacyTextFormatter
{
    public string FormatString(string str)
    {
        // legacy formatting logic
        return $"[Legacy] {str}";
    }
}
```

**Adapter**
```csharp
public class TextFormatterAdapter : ITextFormatter
{
    private readonly LegacyTextFormatter _legacyTextFormatter;

    public TextFormatterAdapter(LegacyTextFormatter legacyTextFormatter)
    {
        _legacyTextFormatter = legacyTextFormatter;
    }

    public string FormatText(string text)
    {
        // call the legacy formatting method
        return _legacyTextFormatter.FormatString(text);
    }
}
```

**Client Code**
```csharp
class Program
{
    static void Main(string[] args)
    {
        LegacyTextFormatter legacyFormatter = new LegacyTextFormatter();
        ITextFormatter formatter = new TextFormatterAdapter(legacyFormatter);

        string formattedText = formatter.FormatText("Hello, World!");
        Console.WriteLine(formattedText);
    }
}
```

# Application Scenarios
The adapter mode is suitable for the following scenarios:

1. When you want to use an existing class, but its interface does not meet your requirements.
2. When you want to create a reusable class that can work with other unrelated or unforeseen classes.
3. When you want to use some existing subclasses, but it is not possible to subclass each one to match their interface.

# Advantages and disadvantages
**Advantages**
Improve class reusability: Through the adapter pattern, existing classes can be reused into new environments without modifying their code.
Improve class flexibility: The adapter pattern allows two incompatible classes to work together, thereby increasing the flexibility of the system.

**Disadvantages**
Increase code complexity: Introducing adapter classes increases the complexity of the system, especially when there are too many layers of adapters.
* Performance overhead: Adapter mode may add some additional call overhead, affecting system performance.