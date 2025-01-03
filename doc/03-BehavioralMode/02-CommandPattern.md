# Overview

A Command Pattern is a behavioral design pattern that encapsulates requests as objects, allowing you to parameterize customers with different requests. The command pattern allows the sender of the request to decoupage from the receiver, so that the sender of the request does not need to know who the recipient of the request is or how to handle the request. Command mode also supports request queuing, logging, and undo operations.

# Structure

The command mode contains the following roles:

1. Command: Defines the interface to perform the operation.
2. Concrete command (ConcreteCommand): Implements the command interface, binds a receiver object, invokes the corresponding operation of the receiver to implement the command.
3. Receiver: An object that performs a specific operation.
4. Invoker: Holds the command object and executes the command when needed.
5. Client: Create a specific command object and set its receiver.

# Sample Code

Suppose we have an application that needs to perform a series of text editing operations (such as write text, undo write, and so on).

**Command Interface**

```csharp
public interface ICommand
{
    void Execute();
    void Undo();
}
```

**Receiver**

```csharp
public class TextEditor
{
    private StringBuilder _text = new StringBuilder();

    public void Write(string text)
    {
        _text.Append(text);
    }

    public void Erase(int length)
    {
        if (length <= _text.Length)
        {
            _text.Remove(_text.Length - length, length);
        }
    }

    public string GetText()
    {
        return _text.ToString();
    }
}
```

**Specific Command**

```csharp
public class WriteCommand : ICommand
{
    private TextEditor _editor;
    private string _text;

    public WriteCommand(TextEditor editor, string text)
    {
        _editor = editor;
        _text = text;
    }

    public void Execute()
    {
        _editor.Write(_text);
    }

    public void Undo()
    {
        _editor.Erase(_text.Length);
    }
}
```

**Invoker**

```csharp
public class TextEditorInvoker
{
    private Stack<ICommand> _commands = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commands.Push(command);
    }

    public void Undo()
    {
        if (_commands.Count > 0)
        {
            ICommand command = _commands.Pop();
            command.Undo();
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
        TextEditor editor = new TextEditor();
        TextEditorInvoker invoker = new TextEditorInvoker();

        ICommand writeCommand1 = new WriteCommand(editor, "Hello, ");
        ICommand writeCommand2 = new WriteCommand(editor, "World!");

        invoker.ExecuteCommand(writeCommand1);
        invoker.ExecuteCommand(writeCommand2);

        Console.WriteLine("Text after write commands: " + editor.GetText());

        invoker.Undo();
        Console.WriteLine("Text after undo: " + editor.GetText());

        invoker.Undo();
        Console.WriteLine("Text after second undo: " + editor.GetText());
    }
}
```

# Application Scenarios

The command mode applies to the following scenarios:

1. Parameterized object: When a request needs to be parameterized to an object.
2. Request queue: When the request needs to be placed in the queue for queuing processing.
3. Support undo operation: Support undo and restore operations when required.
4. Logging: Request logs need to be recorded in order to re-execute the request in the event of a system crash.

# Advantages and disadvantages

**Advantages**

* Decouple request sender and receiver: The command pattern decouples the sender and receiver of a request so that the sender of the request does not need to know who the recipient of the request is or how to handle the request.
Support undo and restore operations: Command mode can easily implement undo and restore operations.
* Support request queuing and logging: Command mode can put requests into queues for queuing processing and record request logs.

**Disadvantages**

* Increases system complexity: The command mode introduces a large number of command classes, increasing the complexity of the system.