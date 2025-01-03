# Overview

A Memento Pattern is a behavioral design pattern that captures the internal state of an object without breaking encapsulation, and saves that state outside the object so that it can be restored to its previous state later. Memo mode implements the undo operation by saving the state of the object so that the object can be restored to the previous state when needed.

# Structure

Memo mode contains the following roles:

1. Memento: Stores the internal state of the originator object and prevents other objects from accessing the memento.
2. Originator: Creates a memo object to record the internal state of the current moment and can use the memo object to restore the internal state.
3. Caretaker: Caretaker is responsible for preserving the object of the memorandum but cannot manipulate or inspect the contents of the memorandum.

# Sample Code

Suppose we have an application that needs to save and restore the state of a text editor.

**Memento**

```csharp
public class TextEditorMemento
{
    public string Text { get; private set; }

    public TextEditorMemento(string text)
    {
        Text = text;
    }
}
```

**Originator**

```csharp
public class TextEditor
{
    public string Text { get; set; }

    public TextEditorMemento Save()
    {
        return new TextEditorMemento(Text);
    }

    public void Restore(TextEditorMemento memento)
    {
        Text = memento.Text;
    }
}
```

**Caretaker**

```csharp
public class TextEditorCaretaker
{
    private Stack<TextEditorMemento> _mementos = new Stack<TextEditorMemento>();

    public void SaveState(TextEditor editor)
    {
        _mementos.Push(editor.Save());
    }

    public void RestoreState(TextEditor editor)
    {
        if (_mementos.Count > 0)
        {
            editor.Restore(_mementos.Pop());
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
        TextEditorCaretaker caretaker = new TextEditorCaretaker();

        editor.Text = "Hello, World!";
        caretaker.SaveState(editor);

        editor.Text = "Hello, Design Patterns!";
        caretaker.SaveState(editor);

        Console.WriteLine("Current Text: " + editor.Text);

        caretaker.RestoreState(editor);
        Console.WriteLine("Restored Text: " + editor.Text);

        caretaker.RestoreState(editor);
        Console.WriteLine("Restored Text: " + editor.Text);
    }
}
```

# Application Scenarios

The memo mode applies to the following scenarios:

1. Need to save and restore the state of an object: You can use the memo mode to save and restore the state of an object.
2. Implement the undo operation: When you need to implement the undo operation, you can use the memorandum mode.
3. Avoid exposing the internal state of the object: When you need to avoid exposing the internal state of the object, you can use the memo mode.

# Advantages and disadvantages

**Advantages**

* Preserve encapsulation: Memo mode preserves the encapsulation of objects by saving the state of objects and avoids exposing the internal state of objects.
* Implement undo operations: Memo mode makes it easy to implement undo operations so that objects can be restored to their previous state.

**Disadvantages**

* Increased memory overhead: Memo mode requires saving the state of an object, which can increase memory overhead, especially if the object is in a large state.
* Implementation complexity: The implementation of the memo pattern can be complex, especially when objects are in a large state.