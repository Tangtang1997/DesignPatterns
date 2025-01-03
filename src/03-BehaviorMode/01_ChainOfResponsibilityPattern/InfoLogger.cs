namespace _01_ChainOfResponsibilityPattern;

public class InfoLogger : Logger
{
    protected override bool CanHandle(int level)
    {
        return level == 1;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("InfoLogger: " + message);
    }
}
