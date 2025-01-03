namespace _06_MementoPattern;

public class TextEditorMemento(string text)
{
    public string Text { get; private set; } = text;
}