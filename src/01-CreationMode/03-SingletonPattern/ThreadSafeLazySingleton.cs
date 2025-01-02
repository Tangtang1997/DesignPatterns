namespace _03_SingletonPattern;

public class ThreadSafeLazySingleton
{
    private static ThreadSafeLazySingleton? _instance;
    private static readonly object Lock = new();

    /// <summary>
    /// 私有构造函数，防止外部实例化
    /// </summary>
    private ThreadSafeLazySingleton() { }

    public static ThreadSafeLazySingleton Instance
    {
        get
        {
            lock (Lock)
            {
                _instance ??= new ThreadSafeLazySingleton();
            }

            return _instance;
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"ThreadSafeLazySingleton Log: {message}");
    }
}