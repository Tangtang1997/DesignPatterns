namespace _06_FlyweightPattern;

public class TreeFactory
{
    private readonly Dictionary<string, ITree> _trees = new();

    public ITree GetTree(string type, string color)
    {
        string key = $"{type}_{color}";
        if (!_trees.ContainsKey(key))
        {
            _trees[key] = new Tree(type, color);
        }
        return _trees[key];
    }
}