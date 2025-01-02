namespace _01_FactoryMethodPattern;

public class DatabaseLoggerFactory : LoggerFactory
{
    public override ILogger CreateLogger()
    {
        return new DatabaseLogger();
    }
}