namespace _06_MementoPattern;

public class TextEditorCaretaker
{
    private readonly Stack<TextEditorMemento> _mementos = new();

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