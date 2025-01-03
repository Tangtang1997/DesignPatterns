// See https://aka.ms/new-console-template for more information
using _04_IteratorPattern;

Console.WriteLine("Hello, World!");

CustomCollection<string> collection = new CustomCollection<string>();
collection.Add("Item 1");
collection.Add("Item 2");
collection.Add("Item 3");

IIterator<string> iterator = collection.CreateIterator();

while (iterator.HasNext())
{
    string item = iterator.Next();
    Console.WriteLine(item);
}