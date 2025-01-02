namespace _03_SingletonPattern;

public class LazyTImplementationSingleton
{
    private static readonly Lazy<LazyTImplementationSingleton> _instance = new(() => new LazyTImplementationSingleton());

    /// <summary>
    /// 私有构造函数，防止外部实例化
    /// </summary>
    private LazyTImplementationSingleton() { }

    public static LazyTImplementationSingleton Instance => _instance.Value;

    public void Log(string message)
    {
        Console.WriteLine($"LazyTImplementationSingleton Log: {message}");
    }
}