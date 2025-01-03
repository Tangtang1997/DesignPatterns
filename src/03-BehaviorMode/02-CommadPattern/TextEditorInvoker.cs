namespace _02_CommadPattern;

public class TextEditorInvoker
{
    private readonly Stack<ICommand> _commands = new();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commands.Push(command);
    }

    public void Undo()
    {
        if (_commands.Count <= 0)
        {
            return;
        }

        ICommand command = _commands.Pop();
        command.Undo();
    }
}