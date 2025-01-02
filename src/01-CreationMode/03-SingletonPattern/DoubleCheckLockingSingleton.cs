namespace _03_SingletonPattern;

public class DoubleCheckLockingSingleton
{
    private static DoubleCheckLockingSingleton? _instance;
    private static readonly object Lock = new();

    /// <summary>
    /// 私有构造函数，防止外部实例化
    /// </summary>
    private DoubleCheckLockingSingleton() { }

    public static DoubleCheckLockingSingleton Instance
    {
        get
        {
            if (_instance != null)
            {
                return _instance;
            }

            lock (Lock)
            {
                _instance ??= new DoubleCheckLockingSingleton();
            }

            return _instance;
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"DoubleCheckLockingSingleton Log: {message}");
    }
}