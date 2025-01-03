namespace _02_CommadPattern;

public class WriteCommand(TextEditor editor, string text) : ICommand
{
    public void Execute()
    {
        editor.Write(text);
    }

    public void Undo()
    {
        editor.Erase(text.Length);
    }
}