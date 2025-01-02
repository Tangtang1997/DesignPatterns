namespace _01_FactoryMethodPattern;

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        // 将日志写入文件
        Console.WriteLine($"FileLogger: {message}");
    }
}