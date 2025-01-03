namespace _02_CommadPattern;

public interface ICommand
{
    void Execute();
    void Undo();
}