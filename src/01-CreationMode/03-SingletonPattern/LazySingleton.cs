namespace _03_SingletonPattern;

public class LazySingleton
{
    private static LazySingleton? _instance;

    /// <summary>
    /// 私有构造函数，防止外部实例化
    /// </summary>
    private LazySingleton() { }

    public static LazySingleton Instance
    {
        get
        {
            return _instance ??= new LazySingleton();
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"LazySingleton Log: {message}");
    }
}