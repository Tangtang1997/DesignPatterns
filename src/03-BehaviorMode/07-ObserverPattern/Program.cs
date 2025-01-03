// See https://aka.ms/new-console-template for more information
using _07_ObserverPattern;

Console.WriteLine("Hello, World!");

Stock appleStock = new Stock("AAPL", 150.00);

IObserver observer1 = new StockObserver("Observer1");
IObserver observer2 = new StockObserver("Observer2");

appleStock.RegisterObserver(observer1);
appleStock.RegisterObserver(observer2);

appleStock.Price = 155.00;
appleStock.Price = 160.00;

appleStock.RemoveObserver(observer1);

appleStock.Price = 165.00;