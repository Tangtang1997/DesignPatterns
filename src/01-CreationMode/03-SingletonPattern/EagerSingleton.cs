namespace _03_SingletonPattern;

public class EagerSingleton
{
    /// <summary>
    /// 私有构造函数，防止外部实例化
    /// </summary>
    private EagerSingleton() { }

    public static EagerSingleton Instance { get; } = new();

    public void Log(string message)
    {
        Console.WriteLine($"EagerSingleton Log: {message}");
    }
}