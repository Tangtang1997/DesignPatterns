namespace _04_IteratorPattern;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
}