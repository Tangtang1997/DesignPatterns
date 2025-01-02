namespace _01_FactoryMethodPattern;

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        // 将日志写入数据库
        Console.WriteLine($"DatabaseLogger: {message}");
    }
}