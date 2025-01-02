namespace _07_ProxyPattern;

public class RealService : IService
{
    public void Request()
    {
        Console.WriteLine("RealService: Handling request.");
    }
}