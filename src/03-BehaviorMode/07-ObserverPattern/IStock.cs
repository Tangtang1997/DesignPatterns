namespace _07_ObserverPattern;

public interface IStock
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}