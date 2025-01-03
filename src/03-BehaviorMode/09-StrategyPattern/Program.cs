// See https://aka.ms/new-console-template for more information
using _09_StrategyPattern;

Console.WriteLine("Hello, World!");

List<int> list = [5, 2, 9, 1, 5, 6];

SortContext context = new SortContext();

context.SetSortStrategy(new BubbleSortStrategy());
context.Sort(list);
Console.WriteLine(string.Join(", ", list));

list = [5, 2, 9, 1, 5, 6];

context.SetSortStrategy(new QuickSortStrategy());
context.Sort(list);
Console.WriteLine(string.Join(", ", list));
