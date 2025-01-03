namespace _01_ChainOfResponsibilityPattern;

public class ErrorLogger : Logger
{
    protected override bool CanHandle(int level)
    {
        return level == 3;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("ErrorLogger: " + message);
    }
}