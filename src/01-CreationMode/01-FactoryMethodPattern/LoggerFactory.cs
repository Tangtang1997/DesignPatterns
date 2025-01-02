namespace _01_FactoryMethodPattern;

public abstract class LoggerFactory
{
    public abstract ILogger CreateLogger();
}