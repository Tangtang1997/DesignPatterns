namespace _07_ObserverPattern;

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