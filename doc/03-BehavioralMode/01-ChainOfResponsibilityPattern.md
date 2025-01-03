# Overview

A Chain of Responsibility Pattern is a behavioral design pattern that passes a request along a chain of handlers until it is processed by a handler. The chain of responsibility pattern gives multiple objects the opportunity to process the request, thereby avoiding coupling between the sender and receiver of the request. By linking the handlers of a request into a chain, the chain of responsibility pattern dynamically specifies the order of the handlers.

# Structure

The Chain of responsibility pattern contains the following roles:

1. Handler(Handler): Define an interface to handle requests and implement the Settings of the chain.
2. ConcreteHandler: Implements a handler interface to process requests for which it is responsible, or to pass the request to a successor.
3. Client : Submits a request to a specific handler object on the chain.

# Sample code

Suppose we have an application that needs to process different levels of log messages (such as information, warnings, and errors).

**Processor Interface**

```csharp
public abstract class Logger
{
    protected Logger _nextLogger;

    public void SetNextLogger(Logger nextLogger)
    {
        _nextLogger = nextLogger;
    }

    public void LogMessage(int level, string message)
    {
        if (CanHandle(level))
        {
            Write(message);
        }
        else if (_nextLogger != null)
        {
            _nextLogger.LogMessage(level, message);
        }
    }

    protected abstract bool CanHandle(int level);
    protected abstract void Write(string message);
}
```

**Specific Handlers**

```csharp
public class InfoLogger : Logger
{
    protected override bool CanHandle(int level)
    {
        return level == 1;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("InfoLogger: " + message);
    }
}

public class WarningLogger : Logger
{
    protected override bool CanHandle(int level)
    {
        return level == 2;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("WarningLogger: " + message);
    }
}

public class ErrorLogger : Logger
{
    protected override bool CanHandle(int level)
    {
        return level == 3;
    }

    protected override void Write(string message)
    {
        Console.WriteLine("ErrorLogger: " + message);
    }
}
```

**Client Code**

```csharp
class Program
{
    static void Main(string[] args)
    {
        Logger infoLogger = new InfoLogger();
        Logger warningLogger = new WarningLogger();
        Logger errorLogger = new ErrorLogger();

        infoLogger.SetNextLogger(warningLogger);
        warningLogger.SetNextLogger(errorLogger);

        infoLogger.LogMessage(1, "This is an information.");
        infoLogger.LogMessage(2, "This is a warning.");
        infoLogger.LogMessage(3, "This is an error.");
    }
}
```

# Application Scenarios

The Chain of responsibility mode is suitable for the following scenarios:

1. Multiple objects can process the same request: The processing order can be dynamically specified between specific processors.
2. A request requires multiple objects to be processed : Handlers can be added or removed dynamically.
3. The handler of the request is unclear: The client does not need to know who the handler of the request is, the handler can be dynamically determined at run time.

## Advantages and disadvantages

**Advantages**

* Reduced coupling: The chain of responsibility pattern gives multiple objects the opportunity to process the request by decoupling the sender and receiver of the request.
* Dynamic combination: Processors can be dynamically combined according to needs, increasing the flexibility and scalability of the system.

**Flaws**

* Request processing is not guaranteed ** : If all processors on the chain cannot process the request, it may result in the request not being processed.
* Performance overhead ** : Chain of Responsibility mode may increase the performance overhead of the system, especially if the chain is too long.