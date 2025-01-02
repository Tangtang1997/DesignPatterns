# Overview
A Singleton Pattern is a creative design pattern that ensures that there is only one instance of a class and provides a global access point to access that instance. This pattern is common in many scenarios, such as database connection pooling, loggers, configuration managers, and so on, and improves code flexibility and maintainability by ensuring that there is only one instance of a class.

# Structure
The singleton pattern typically contains the following roles:

1. Private constructor: prevents external instantiation.
2. Static private variables: used to store singleton instances.
3. Public static methods: Provide global access points and return singleton instances.

# Sample code
The singleton pattern can be implemented in a variety of ways, but several common variants are listed below:

## Eager Initialization
It is thread-safe to create an instance when the class is loaded, but wastes resources if the instance is not in use.

```csharp
public class EagerSingleton
{
    /// <summary>
    /// Private constructor, prevent external instantiation.
    /// </summary>
    private EagerSingleton() { }

    public static EagerSingleton Instance { get; } = new();

    public void Log(string message)
    {
        Console.WriteLine($"EagerSingleton Log: {message}");
    }
}
```

## Lazy Initialization
Lazy creates instances the first time it is used and is not thread-safe.

```csharp
public class LazySingleton
{
    private static LazySingleton? _instance;

    /// <summary>
    /// Private constructor, prevent external instantiation.
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
```

## Thread-Safe Lazy Initialization
Thread safety is achieved by locking, but the performance is low.

```csharp
public class ThreadSafeLazySingleton
{
    private static ThreadSafeLazySingleton? _instance;
    private static readonly object Lock = new();

    /// <summary>
    /// Private constructor, prevent external instantiation.
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
```

## Double-Check Locking
Check before and after locking to reduce locking overhead.

```csharp
public class DoubleCheckLockingSingleton
{
    private static DoubleCheckLockingSingleton? _instance;
    private static readonly object Lock = new();

    /// <summary>
    /// Private constructor, prevent external instantiation.
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
```

## Static Inner Class
Use the features of static inner classes for lazy loading and thread safety.

```csharp
public class StaticInnerClassSingleton
{
    /// <summary>
    /// Private constructor, prevent external instantiation.
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
```

Lazy<T> Implementation in.NET
Implement thread-safe Lazy loading using the Lazy<T> type in.NET.

```csharp
public class LazyTImplementationSingleton
{
    private static readonly Lazy<LazyTImplementationSingleton> _instance = new(() => new LazyTImplementationSingleton());

    /// <summary>
    /// Private constructor, prevent external instantiation.
    /// </summary>
    private LazyTImplementationSingleton() { }

    public static LazyTImplementationSingleton Instance => _instance.Value;

    public void Log(string message)
    {
        Console.WriteLine($"LazyTImplementationSingleton Log: {message}");
    }
}
```

# Application Scenarios
The singleton mode applies to the following scenarios:

1. When there is only one instance of a class and the client can access it from a well-known access point.
2. When this unique instance should be extensible by subclassing, and the client should be able to use an extended instance without changing the code.

# Advantages and disadvantages
**Advantages**
Control the number of instances: Singleton mode ensures that there is only one instance of a class, saving system resources.
* Global Access Point: Provides a global access point for easy access to instances.

**Disadvantages**
* Difficult to extend: Since singleton classes cannot be instantiated more than once, extending singleton classes can be difficult.
Hide dependencies: The singleton pattern may hide dependencies between classes, adding complexity to your code.
