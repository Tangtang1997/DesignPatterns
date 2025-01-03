namespace _06_MementoPattern;

public class TextEditor
{
    public string Text { get; set; } = string.Empty;

    public TextEditorMemento Save()
    {
        return new TextEditorMemento(Text);
    }

    public void Restore(TextEditorMemento memento)
    {
        Text = memento.Text;
    }
}