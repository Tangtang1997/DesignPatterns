# Overview

The Observer Pattern is a behavioral design pattern that defines a one-to-many dependency where multiple observers simultaneously listen to a subject object. When the state of the subject object changes, all observer objects that depend on it are notified and automatically updated. The observer mode reduces the coupling degree between objects and improves the flexibility and maintainability of the system.

# Structure

The Observer mode contains the following roles:

1. Subject: Defines methods for registering, removing, and notifying observers.
2. ConcreteSubject: Implements the topic interface, maintains a list of observers, and notifies all observers when state changes.
3. Observer: Defines an update interface that updates itself when it receives a notification from a topic.
4. ConcreteObserver: Implements the observer interface, updating its own state to match the state of the subject.

# Sample Code

Suppose we have an application that needs to implement a simple stock price notification system.

**Subject Interface**

```csharp
public interface IStock
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
```

**Specific Subject**

```csharp
public class Stock(string symbol, double price) : IStock
{
    private readonly List<IObserver> _observers = [];

    public string Symbol => symbol;

    public double Price
    {
        get => price;
        set
        {
            price = value;
            NotifyObservers();
        }
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }
}
```

**Observer Interface**

```csharp
public interface IObserver
{
    void Update(Stock stock);
}
```

**Specific Observer**

```csharp
public class StockObserver(string name) : IObserver
{
    public void Update(Stock stock)
    {
        Console.WriteLine($"Observer {name}: Stock {stock.Symbol} price updated to {stock.Price}");
    }
}
```

**Client Code**

```csharp
class Program
{
    static void Main(string[] args)
    {
        Stock appleStock = new Stock("AAPL", 150.00);

        IObserver observer1 = new StockObserver("Observer1");
        IObserver observer2 = new StockObserver("Observer2");

        appleStock.RegisterObserver(observer1);
        appleStock.RegisterObserver(observer2);

        appleStock.Price = 155.00;
        appleStock.Price = 160.00;

        appleStock.RemoveObserver(observer1);

        appleStock.Price = 165.00;
    }
}
```

# Application Scenarios
The observer mode is suitable for the following scenarios:

1. There is a one-to-many relationship between objects: when the state of one object changes, it is necessary to notify multiple other objects and make them update automatically.
2. There are dependencies between objects in the system: When there are dependencies between objects, but you do not want these objects to be tightly coupled, you can use the observer pattern.

# Advantages and disadvantages

**Advantages**

* Less coupling: Observer mode improves system flexibility and maintainability by decoupling observers and subjects so that they can change independently.
* Support for broadcast communication: Subject objects can send notifications to all registered observers, enabling broadcast communication.

**Disadvantages**

* May cause performance problems: If there are too many observers, notifying all observers may cause performance problems.
* May cause memory leaks: If the observer is not unregistered in time, it may cause memory leaks.
