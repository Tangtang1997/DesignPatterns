# Overview
A Decorator Pattern is a structural design pattern that allows new functionality to be added to an existing object without changing its structure. The decorator mode provides additional functionality while keeping the class method signature intact by creating a decorator class to wrap the original class. Decorative modes are more flexible than generated subclasses and can dynamically extend an object's functionality.

# Structure
The decorative mode contains the following characters:

1. Component: Define an interface to objects that dynamically add responsibilities to them.
2. Concrete component (ConcreteComponent) : A concrete object that implements a component interface.
3. Decorator: Implements the component interface and holds a reference to the component object.
4. ConcreteDecorator: Extend the decorator class to add additional functionality.

# Sample code
Suppose we have an application that needs to add different decorations (such as encryption and compression) for different types of messages.

**Component Interface**
```csharp
public interface IMessage
{
    string GetContent();
}
```

**Specific Component**
```csharp
public class TextMessage : IMessage
{
    private string _content;

    public TextMessage(string content)
    {
        _content = content;
    }

    public string GetContent()
    {
        return _content;
    }
}
```

**Decorator**
```csharp
public abstract class MessageDecorator : IMessage
{
    protected IMessage _message;

    protected MessageDecorator(IMessage message)
    {
        _message = message;
    }

    public abstract string GetContent();
}
```

**Specific Decorator**
```csharp
public class EncryptedMessage : MessageDecorator
{
    public EncryptedMessage(IMessage message) : base(message) { }

    public override string GetContent()
    {
        return Encrypt(_message.GetContent());
    }

    private string Encrypt(string content)
    {
        // sample encryption logic (just for example)
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(content));
    }
}

public class CompressedMessage : MessageDecorator
{
    public CompressedMessage(IMessage message) : base(message) { }

    public override string GetContent()
    {
        return Compress(_message.GetContent());
    }

    private string Compress(string content)
    {
        // sample compression logic (just for example)
        return $"Compressed({content})";
    }
}
```

**Client Code**
```csharp
class Program
{
    static void Main(string[] args)
    {
        IMessage message = new TextMessage("Hello, World!");

        // add encryption decoration
        IMessage encryptedMessage = new EncryptedMessage(message);
        Console.WriteLine(encryptedMessage.GetContent());

        // add
        IMessage compressedMessage = new CompressedMessage(message);
        Console.WriteLine(compressedMessage.GetContent());

        // add encryption and compression
        IMessage encryptedAndCompressedMessage = new CompressedMessage(encryptedMessage);
        Console.WriteLine(encryptedAndCompressedMessage.GetContent());
    }
}
```

# Application Scenarios
Decorative mode is suitable for the following scenarios:

1. When you want to dynamically add functionality to objects without changing class files or using inheritance.
2. When you want to be able to revoke or add features dynamically.
3. When the way to extend functionality by generating subclasses is difficult or inappropriate.

# Advantages and disadvantages
**Advantages**
* High flexibility: Decorative mode allows you to dynamically combine objects and add or remove functionality at runtime.
* Follow the single responsibility principle: By dividing functionality into different classes, the decorative pattern makes each class focus on a specific function.
**Disadvantages**
Increase code complexity: Using decorator mode increases the number of classes and objects in the system, resulting in increased code complexity.
* Debugging difficulties: Because the functionality is dynamically combined through multiple decorative classes, debugging can be difficult.
