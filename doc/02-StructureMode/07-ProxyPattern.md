# Overview
A Proxy Pattern is a structural design pattern that provides a proxy for other objects to control access to that object. By introducing a proxy object to control access to the original object, the proxy pattern can extend its functionality without changing the original object. Proxy mode is commonly used in scenarios such as lazy loading, access control, and logging.

# Structure
The proxy pattern contains the following roles:

1. Abstract Subject: Defines the public interface of the proxy class and the real class.
2. RealSubject: An abstract subject interface is implemented to represent the real object represented by the agent.
3. Proxy: Implements an abstract topic interface, contains references to real topic objects, and can control access to real topics.

# Sample code
Suppose we have an application that needs to control access to a service through a proxy object, such as access control for a remote service.

**Abstract Subject**
```csharp
public interface IService
{
    void Request();
}
```

**RealSubject**
```csharp
public class RealService : IService
{
    public void Request()
    {
        Console.WriteLine("RealService: Handling request.");
    }
}
```

**Proxy**
```csharp
public class ServiceProxy : IService
{
    private RealService _realService;
    private bool _isAuthorized;

    public ServiceProxy(bool isAuthorized)
    {
        _realService = new RealService();
        _isAuthorized = isAuthorized;
    }

    public void Request()
    {
        if (_isAuthorized)
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
```

**Client Code**
```csharp
class Program
{
    static void Main(string[] args)
    {
        IService authorizedProxy = new ServiceProxy(true);
        authorizedProxy.Request();

        IService unauthorizedProxy = new ServiceProxy(false);
        unauthorizedProxy.Request();
    }
}
```

# Application Scenarios
The proxy mode applies to the following scenarios:

1. Remote proxy: provides local representation for an object in different address Spaces. This hides the fact that an object exists in a different address space.
2. Virtual agents: Create expensive objects as needed. It is used to store real objects that take a long time to instantiate.
3. Protection Agent: Controls access to the original object. Protection agents are used when objects should have different access rights.
4. Intelligent guidance: Instead of simple Pointers, it performs some additional operations when accessing objects.

# Advantages and disadvantages
**Advantages**
Control object access: The proxy mode can control access to real objects, increasing the security and flexibility of the system.
* Delayed loading: The proxy mode can achieve delayed loading and optimize system performance.
* Logging: Proxy mode allows logging while accessing real objects for easy debugging and monitoring.

**Disadvantages**
Increase system complexity: Introducing proxy objects increases the complexity of the system, especially when there are too many layers of agents.
* Performance overhead: Proxy mode may add some additional call overhead, affecting system performance.
