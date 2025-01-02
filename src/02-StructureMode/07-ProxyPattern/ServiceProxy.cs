namespace _07_ProxyPattern;

public class ServiceProxy(bool isAuthorized) : IService
{
    private readonly RealService _realService = new();

    public void Request()
    {
        if (isAuthorized)
        {
            Console.WriteLine("ServiceProxy: Authorizing request.");
            _realService.Request();
        }
        else
        {
            Console.WriteLine("ServiceProxy: Unauthorized request.");
        }
    }
}