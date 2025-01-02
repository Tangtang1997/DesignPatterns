namespace _03_SingletonPattern;

public class StaticInnerClassSingleton
{
    /// <summary>
    /// 私有构造函数，防止外部实例化
    /// </summary>
    private StaticInnerClassSingleton() { }

    private static class SingletonHolder
    {
        internal static readonly StaticInnerClassSingleton _instance = new();
    } 

    public static StaticInnerClassSingleton Instance => SingletonHolder._instance;

    public void Log(string message)
    {
        Console.WriteLine($"StaticInnerClassSingleton Log: {message}");
    }
}