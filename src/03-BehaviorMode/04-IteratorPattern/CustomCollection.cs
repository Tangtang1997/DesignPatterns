namespace _04_IteratorPattern;

public class CustomCollection<T> : IAggregate<T>
{
    private readonly List<T> _items = [];

    public void Add(T item)
    {
        _items.Add(item);
    }

    public IIterator<T> CreateIterator()
    {
        return new CustomIterator(this);
    }

    public int Count => _items.Count;

    public T this[int index] => _items[index];

    private class CustomIterator(CustomCollection<T> collection) : IIterator<T>
    {
        private int _currentIndex;

        public bool HasNext()
        {
            return _currentIndex < collection.Count;
        }

        public T Next()
        {
            return collection[_currentIndex++];
        }
    }
}