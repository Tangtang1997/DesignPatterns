namespace _01_ChainOfResponsibilityPattern;

public class WarningLogger : Logger
{
    protected override bool CanHandle(int level)
    {
        return level == 2;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("WarningLogger: " + message);
    }
}