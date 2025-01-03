namespace _01_ChainOfResponsibilityPattern;

public abstract class Logger
{
    protected Logger? NextLogger;

    public void SetNextLogger(Logger nextLogger)
    {
        NextLogger = nextLogger;
    }

    public void LogMessage(int level, string message)
    {
        if (CanHandle(level))
        {
            Write(message);
        }
        else
        {
            NextLogger?.LogMessage(level, message);
        }
    }

    protected abstract bool CanHandle(int level);
    protected abstract void Write(string message);
}