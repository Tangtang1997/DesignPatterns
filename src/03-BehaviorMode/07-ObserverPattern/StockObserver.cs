namespace _07_ObserverPattern;

public class StockObserver(string name) : IObserver
{
    public void Update(Stock stock)
    {
        Console.WriteLine($"Observer {name}: Stock {stock.Symbol} price updated to {stock.Price}");
    }
}