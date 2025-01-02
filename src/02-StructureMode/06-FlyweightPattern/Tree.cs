namespace _06_FlyweightPattern;

public class Tree(string type, string color) : ITree
{
    public void Display(int x, int y)
    {
        Console.WriteLine($"Tree of type {type} and color {color} is at ({x}, {y})");
    }
}